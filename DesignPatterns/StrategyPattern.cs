using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    /// <summary>
    /// Strategy pattern is also called Composition Pattern wherein it enables 
    /// different objects to dynamically add features (behaviour)
    /// </summary>
    class StrategyPattern
    {

    }

    public interface IFileComment
    {
        string writecomment();
    }

    class XmlComment : IFileComment
    {
        public string writecomment()
        {
            return "<xml> comment";
        }
    }

    class pipeComment : IFileComment
    {
        public string writecomment()
        {
            return "| pipe comment";
        }
    }

    abstract class FileReader
    {
        public abstract void writeFile();
        public abstract void readFile();

        protected IFileComment FileComment;
    }

    class XmlFileReader : FileReader
    {
        private IFileComment _instanceComment;
        public override void readFile()
        {
            Console.WriteLine("Reading XML File...");
        }

        public override void writeFile()
        {
            Console.WriteLine(WriteComment());
            Console.WriteLine("Writing XML File...");
        }

        public void EnableComment(IFileComment comment)
        {
            _instanceComment = comment;
        }

        public string WriteComment()
        {
            if (_instanceComment == null)
                return "Comment not Enabled";
            return _instanceComment.writecomment();
        }
    }

}
