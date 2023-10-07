using CourseNoteSorter.Abstrect;

namespace CourseNoteSorter.Commands
{
    internal class SaveToBinaryCommand : ICommand
    {
        private ISaveable _item;
        private string _file;
        public SaveToBinaryCommand(ISaveable item,string file)
        {
            _item = item;
            _file = file;
        }
        public void Execute()
        {
            using (BinaryWriter bw = new BinaryWriter(File.Open(_file, FileMode.OpenOrCreate)))
            {
                bw.Write((int)_item.Signatur);
                _item.Save(bw);
            }
        }
    }
}
