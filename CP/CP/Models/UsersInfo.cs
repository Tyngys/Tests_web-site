using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CP.Data.Models;

namespace CP.Web.Models
{
    public class UsersInfo
    {
        public List<User> InfoList { get; set; } = new List<User>();

        public double[] ArrayAverg { get; set; } = new double[5];
        public double[] ArrayArgvMiss { get; set; } = new double[5];
        public double[] ArrayStErrorAvergMath { get; set; } = new double[5];

        public UsersInfo(List<User> listUsers)
        {
            this.InfoList = listUsers;           
            this.GetAverg(listUsers);
            this.GetAvergMiss(listUsers);
            this.GetStErrorAvergMath(listUsers);
        }

        public void GetAverg(List<User> listUser)
        {
            double[] arraySum = new double[5];
            for (int i = 0; i < listUser.Count; i++)
            {
                arraySum[0] += listUser[i].P_D;
                arraySum[1] += listUser[i].A_S;
                arraySum[2] += listUser[i].N_O;
                arraySum[3] += listUser[i].S_L;
                arraySum[4] += listUser[i].K;
            }
            
            this.ArrayAverg[0] = arraySum[0] / listUser.Count;
            this.ArrayAverg[1] = arraySum[1] / listUser.Count;
            this.ArrayAverg[2] = arraySum[2] / listUser.Count;
            this.ArrayAverg[3] = arraySum[3] / listUser.Count;
            this.ArrayAverg[4] = arraySum[4] / listUser.Count;
        }

        public void GetAvergMiss(List<User> listUser)
        {
            for (int i = 0; i < listUser.Count; i++)
            {
                this.ArrayArgvMiss[0] += this.ArrayAverg[0] / Math.Sqrt(listUser[i].P_D);
                this.ArrayArgvMiss[1] += this.ArrayAverg[1] / Math.Sqrt(listUser[i].A_S);
                this.ArrayArgvMiss[2] += this.ArrayAverg[2] / Math.Sqrt(listUser[i].N_O);
                this.ArrayArgvMiss[3] += this.ArrayAverg[3] / Math.Sqrt(listUser[i].S_L);
                this.ArrayArgvMiss[4] += this.ArrayAverg[4] / Math.Sqrt(listUser[i].K);
            }
        }

        public void GetStErrorAvergMath(List<User> listUser)
        {
            for (int i = 0; i < listUser.Count; i++)
            {
                this.ArrayStErrorAvergMath[0] += Math.Sqrt(Math.Pow(listUser[i].P_D - this.ArrayAverg[0], 2) / listUser.Count);
                this.ArrayStErrorAvergMath[1] += Math.Sqrt(Math.Pow(listUser[i].A_S - this.ArrayAverg[1], 2) / listUser.Count);
                this.ArrayStErrorAvergMath[2] += Math.Sqrt(Math.Pow(listUser[i].N_O - this.ArrayAverg[2], 2) / listUser.Count);
                this.ArrayStErrorAvergMath[3] += Math.Sqrt(Math.Pow(listUser[i].S_L - this.ArrayAverg[3], 2) / listUser.Count);
                this.ArrayStErrorAvergMath[4] += Math.Sqrt(Math.Pow(listUser[i].K - this.ArrayAverg[4], 2) / listUser.Count);
            }
        }
    }
}