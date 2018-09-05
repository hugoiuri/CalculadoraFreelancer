﻿using CalculadoraFreelancer.Domain.Interfaces;
using CalculadoraFreelancer.Domain.Profissionais;
using CalculadoraFreelancer.Domain.Projetos;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CalculadoraFreelancer.Infra.Data.Repository
{
    public class DatabaseContext
    {
        static DatabaseContext DatabaseSingleton;
        static SQLiteAsyncConnection Conn;

        public static SQLiteAsyncConnection Database
        {
            get
            {
                if (DatabaseSingleton == null)
                    DatabaseSingleton = new DatabaseContext();

                return Conn;
            }
        }

        public DatabaseContext()
        {
            var caminhoBancoDeDados = DependencyService.Get<IDatabaseFile>().GetFilePath("calcfreelancer.db3");
            Conn = new SQLiteAsyncConnection(caminhoBancoDeDados);

            Conn.CreateTableAsync<Projeto>().Wait();
            Conn.CreateTableAsync<Profissional>().Wait();
        }
    }
}
