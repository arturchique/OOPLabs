using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreyCode
{
    public class ConditionsModel
    {
        public int num;
        public string bin;
        public string binGrey;
        public int numGrey;
        public string sys_;

        public ConditionsModel(int num, string bin, string binGrey, int numGrey, string sys_)
        {
            this.num = num;
            this.bin = bin;
            this.binGrey = binGrey;
            this.numGrey = numGrey;
            this.sys_ = sys_;
        }
        public ConditionsModel()
        {

        }
    }
}
