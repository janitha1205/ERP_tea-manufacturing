using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class mechineDTO
    {
        public int ID {  get; set; }    
        public int MechID {  get; set; }
        public string Description {  get; set; }
        public int LabourID {  get; set; }
        public bool IsDown { get; set; }
        public int active_range { set; get; }
        public int Type {  get; set; }  //mechine cat
    }
}
