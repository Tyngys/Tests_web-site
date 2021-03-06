﻿using System;
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
                this.ArrayArgvMiss[0] += Math.Abs(this.ArrayAverg[0] - listUser[i].P_D) / listUser.Count;
                this.ArrayArgvMiss[1] += Math.Abs(this.ArrayAverg[1] - listUser[i].A_S) / listUser.Count;
                this.ArrayArgvMiss[2] += Math.Abs(this.ArrayAverg[2] - listUser[i].N_O) / listUser.Count;
                this.ArrayArgvMiss[3] += Math.Abs(this.ArrayAverg[3] - listUser[i].S_L) / listUser.Count;
                this.ArrayArgvMiss[4] += Math.Abs(this.ArrayAverg[4] - listUser[i].K) / listUser.Count;
            }
        }

        public void GetStErrorAvergMath(List<User> listUser)
        {
                this.ArrayStErrorAvergMath[0] = this.ArrayArgvMiss[0] / Math.Sqrt(listUser.Count);
                this.ArrayStErrorAvergMath[1] = this.ArrayArgvMiss[1] / Math.Sqrt(listUser.Count);
                this.ArrayStErrorAvergMath[2] = this.ArrayArgvMiss[2] / Math.Sqrt(listUser.Count);
                this.ArrayStErrorAvergMath[3] = this.ArrayArgvMiss[3] / Math.Sqrt(listUser.Count);
                this.ArrayStErrorAvergMath[4] = this.ArrayArgvMiss[4] / Math.Sqrt(listUser.Count);
        }
    }
}