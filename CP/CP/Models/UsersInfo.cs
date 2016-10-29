using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CP.Data.Models;

namespace CP.Web.Models
{
    public class UsersInfo
    {
        public List<UserModel> InfoList { get; set; } = new List<UserModel>();

        public double[] ArrayAverg { get; set; } = new double[5];
        public double[] ArrayArgvMiss { get; set; } = new double[5];
        public double[] ArrayStErrorAvergMath { get; set; } = new double[5];

        public UsersInfo(List<User> listUsers)
        {
            foreach (User user in listUsers)
            {
                this.InfoList.Add(new UserModel() {A_S = user.A_S, Age = user.Age, Gender = user.Gender, P_D = user.P_D, UserName = user.UserName, K = user.K, N_O = user.N_O, S_L = user.S_L});
            }
           
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
                this.ArrayArgvMiss[0] += Math.Abs(listUser[i].P_D - this.ArrayAverg[0]) / listUser.Count;
                this.ArrayArgvMiss[1] += Math.Abs(listUser[i].A_S - this.ArrayAverg[1]) / listUser.Count;
                this.ArrayArgvMiss[2] += Math.Abs(listUser[i].N_O - this.ArrayAverg[2]) / listUser.Count;
                this.ArrayArgvMiss[3] += Math.Abs(listUser[i].S_L - this.ArrayAverg[3]) / listUser.Count;
                this.ArrayArgvMiss[4] += Math.Abs(listUser[i].K - this.ArrayAverg[4]) / listUser.Count;
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