using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    delegate bool Find(Student std);
    class studentextend
    {
        public static Student[] where(Student[] stdArray,Find del)
        {
            int i = 0;
            Student[] result = new Student[10];
            foreach (Student std in stdArray)
            {
                if (del(std))
                {
                    result[i] = std;
                    i++;
                }
            }
            return result;
        }
    }
}
