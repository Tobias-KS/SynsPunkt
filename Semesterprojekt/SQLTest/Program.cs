using System;
using System.Collections.Generic;
using System.Text;
using BusinessLogic;
using Persistence;
using Persistence.CRUD;
using Persistence.Models;

namespace SQLTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string F = "FTest";
            string L = "LTest";
            string A = "ATest";
            int P = 44332211;
            string E = "test@testE.dk";
            int R = 2;
            int LE = 1;
            string N = "NTest";
            DateTime D = new DateTime(2016, 3, 2);
            int C = 117;
            Updater.AlterCustomer(F, L, A, P, E, R, LE, N, D, C);
        }
    }
}
