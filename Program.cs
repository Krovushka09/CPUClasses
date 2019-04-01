using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPU_Info
{
    /// <summary>
    /// Возможности пользователя
    /// </summary>
    class FunctionForUsers
    {
        /// <summary>
        /// Авторизация
        /// </summary>
        public UserType Authorization { get; set; }

        /// <summary>
        /// сортировка процессоров по производителям
        /// </summary>
        public List<CPU> List_of_CPU_AMD { get; set; }
        public List<CPU> List_of_CPU_INTEL { get; set; }

        /// <summary>
        /// сортировка процессоров по типу
        /// </summary>
        public List<CPU_Type> List_of_CPU_Type { get; set; }

        /// <summary>
        /// поиск статей
        /// </summary>
        public List<Articles> List_of_Artiles { get; set; }
    }


    /// <summary>
    /// процессор
    /// </summary>
    class CPU
    {
        /// <summary>
        /// характеристики процессора
        /// </summary>
        public Vendor Name_of_vendor { get; set; }
        public DateTime Release_date { get; set; }
        public string Name_of_CPU { get; set; }
        public int Numbers_of_cores { get; set; }
        public int Numbers_of_threads { get; set; }
        public int Soket { get; set; }
        public double Size_of_cacheL1 { get; set; }
        public double Size_of_cacheL2 { get; set; }
        public double Size_of_cacheL3 { get; set; }
    }

    /// <summary>
    /// Статьи
    /// </summary>
    class Articles
    {
        /// <summary>
        /// Заголовок статьи
        /// </summary>
        public string Headline { get; set; }

        /// <summary>
        /// Дата публикации статьи
        /// </summary>
        public DateTime Publication_date { get; set; }

        /// <summary>
        /// Тип статьи
        /// </summary>
        public Articles_Type Type_of_articles { get; set; }

        /// <summary>
        /// Прошла ли статья проверку
        /// </summary>
        public bool Articlec_check { get; set; }
    }

    /// <summary>
    /// Продавец/изготавитель процессора
    /// </summary>
    public enum Vendor { AMD, Intel }

    /// <summary>
    /// Типы пользователей
    /// </summary>
    public enum UserType
    {
        /// <summary>
        /// Пользователь
        /// </summary>
        User,

        /// <summary>
        /// Админ
        /// </summary>
        Admin
    }

    /// <summary>
    /// Тип процессора
    /// </summary>
    public enum CPU_Type
    {
        /// <summary>
        /// Мобильный(ноутбук)
        /// </summary>
        Mobile,
        /// <summary>
        /// Десктопный
        /// </summary>
        Desktop,
        /// <summary>
        /// Серверный
        /// </summary>
        Server
    }

    /// <summary>
    /// Типы статей
    /// </summary>
    public enum Articles_Type
    {
        /// <summary>
        /// Новинки
        /// </summary>
        New,
        /// <summary>
        /// Старые мощные процессоры
        /// </summary>
        Old_but_powerful,
        /// <summary>
        /// Бюджетные
        /// </summary>
        Budgetary,
        /// <summary>
        /// Среднего класса
        /// </summary>
        Midddle_price,
        /// <summary>
        /// Дорогие
        /// </summary>
        Over_price,
    }
}
