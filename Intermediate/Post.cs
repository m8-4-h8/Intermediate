using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate
{
    internal class Post
    {
        public string Tittle {  get; set; }
        public string Description { get; set; }
        public DateTime CreateTime { get; set; }

        private int _currentVote;
        public void UpVote()
        {
            _currentVote += 1;
        }
        public void DownVote()
        {
            _currentVote -= 1;
        }
        public void DisplayVote()
        {
            Console.WriteLine(_currentVote);
        }
    }
}
