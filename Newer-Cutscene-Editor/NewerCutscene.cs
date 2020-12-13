using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Newer_Cutscene_Editor
{
    class NewerCutscene
    {
        internal uint sceneCount = new uint();
        internal List<NewerScene> scenes = new List<NewerScene>();

        public uint getNextInt32(ref int index, List<byte> rawdata)
        {
            byte[] nextInt32 = { rawdata[index++], rawdata[index++], rawdata[index++], rawdata[index++] };
            Array.Reverse(nextInt32);
            return BitConverter.ToUInt32(nextInt32, 0);
        }
        public string getNextString(uint index, List<byte> rawdata)
        {
            List<char> nextString = new List<char>();
            while (rawdata[(int)index] != 0)
            {
                nextString.Add((char)rawdata[(int)index]);
                index++;
            }
            return new string(nextString.ToArray());
        }
        public void addNextInt32(ref List<byte> data, uint intToAdd)
        {
            foreach (byte currentByte in BitConverter.GetBytes(intToAdd).Reverse<byte>())
            {
                data.Add(currentByte);
            }
        }
        public void InsertInt32(ref List<byte> data, uint intToAdd, int atIndex)
        {
            byte[] int32ToInsert = BitConverter.GetBytes(intToAdd).Reverse<byte>().ToArray();
            for (int i = 0; i < 4; i++)
            {
                data[atIndex + i] = int32ToInsert[i];
            }
        }
        public void addNextString(ref List<byte> data, string stringToAdd)
        {
            foreach(char c in stringToAdd)
            {
                data.Add((byte)c);
            }
        }

        public List<byte> saveFile() {
            List<byte> thisData = new List<byte>();

            addNextString(ref thisData, "NWcs");
            addNextInt32(ref thisData, this.sceneCount);
            for(int i = 0; i < this.sceneCount; i++)
            {
                addNextInt32(ref thisData, 0); //We'll get back to these later
            }
            List<uint> sceneOffsets = new List<uint>();
            List<string> filenameStrings = new List<string>();
            foreach(NewerScene thisScene in this.scenes)
            {
                sceneOffsets.Add((uint)thisData.Count);

                addNextInt32(ref thisData, 0); //We'll get back to this later
                filenameStrings.Add(thisScene.filename);

                thisData.Add(thisScene.widescreenFlag);
                thisData.Add(0);
                thisData.Add(0);
                thisData.Add(0);

                addNextInt32(ref thisData, thisScene.commandCount);

                foreach (NewerCommand thisCommand in thisScene.commands)
                {
                    addNextInt32(ref thisData, thisCommand.commandID);
                    addNextInt32(ref thisData, thisCommand.param1);
                    addNextInt32(ref thisData, thisCommand.param2);
                    if (thisCommand.commandID > 1)
                    {
                        addNextInt32(ref thisData, thisCommand.param3);
                    }
                }
            }

            for (int i = 8; i < ((this.sceneCount * 4) + 8); i += 4) {
                InsertInt32(ref thisData, sceneOffsets[(i - 8) / 4], i);
            }

            List<uint> stringOffsets = new List<uint>();
            foreach(string thisString in filenameStrings)
            {
                stringOffsets.Add((uint)thisData.Count);
                addNextString(ref thisData, thisString);
                thisData.Add(0);
            }

            for(int i = 0; i < stringOffsets.Count; i++)
            {
                InsertInt32(ref thisData, stringOffsets[i], (int)sceneOffsets[i]);
            }

            return thisData;
        }

        public void loadFile(string path, ref List<byte> rawdata)
        {
            sceneCount = new uint();
            scenes = new List<NewerScene>();
            rawdata = new List<byte>();

            //Reads the Cutscene file, this little part was done by Lory some months ago for one of my older projects, i reused it for this tool as it works good. Thanks to him !
            FileStream rawSave = File.Open(path, FileMode.Open);
            try
            {
                BinaryReader binReader = new BinaryReader(rawSave);
                byte b = binReader.ReadByte();
                while (b != null)
                {
                    rawdata.Add(b);
                    b = binReader.ReadByte();
                }
                binReader.Close();
            }
            catch (EndOfStreamException e)
            {
                Console.WriteLine("reached end of stream");
                rawSave.Close();
            }

            //make it a string and an int for future things

            //make it a string and an int for future things
            char[] rawstring = Encoding.UTF8.GetString(rawdata.ToArray(), 0, rawdata.ToArray().Length).ToCharArray();
            uint[] rawint = new uint[rawdata.ToArray().Length];
            for (int i = 0; i < rawdata.ToArray().Length - 1; i++)
            {
                rawint[i] = Convert.ToUInt32(rawdata[i].ToString());
            }

            //Checks the header
            if (rawstring[0] != 'N' || rawstring[1] != 'W' || rawstring[2] != 'c' || rawstring[3] != 's')
            {
                MessageBox.Show("Invalid CS File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //Here the fun starts (or not)

                int currentOffset = 4;

                this.sceneCount = getNextInt32(ref currentOffset, rawdata);

                List<uint> sceneOffsets = new List<uint>();
                for (int i = 0; i < this.sceneCount; i++)
                {
                    sceneOffsets.Add(getNextInt32(ref currentOffset, rawdata));
                }
                foreach (uint sceneOffset in sceneOffsets)
                {
                    currentOffset = (int)sceneOffset;
                    NewerScene thisScene = new NewerScene();
                    thisScene.filename = getNextString(getNextInt32(ref currentOffset, rawdata), rawdata);
                    thisScene.widescreenFlag = rawdata[currentOffset++];
                    currentOffset += 3;
                    thisScene.commandCount = getNextInt32(ref currentOffset, rawdata);

                    for (int i = 0; i < thisScene.commandCount; i++)
                    {
                        NewerCommand thisCommand = new NewerCommand();
                        thisCommand.commandID = getNextInt32(ref currentOffset, rawdata);
                        thisCommand.param1 = getNextInt32(ref currentOffset, rawdata);
                        thisCommand.param2 = getNextInt32(ref currentOffset, rawdata);
                        if (thisCommand.commandID > 1)
                        {
                            thisCommand.param3 = getNextInt32(ref currentOffset, rawdata);
                        }

                        thisScene.commands.Add(thisCommand);
                    }

                    this.scenes.Add(thisScene);
                }
            }
        }

        public class NewerScene
        {
            internal string filename = "";
            internal byte widescreenFlag = new byte();
            internal uint commandCount = new uint();
            internal List<NewerCommand> commands = new List<NewerCommand>();
        }

        public class NewerCommand
        {
            internal uint commandID = new uint();
            internal uint param1 = new uint();
            internal uint param2 = new uint();
            internal uint param3 = new uint();
        }
    }
}
