﻿using System;


namespace CBFitness.BL.Model
{
    /// <summary>
    /// Пользователь.
    /// </summary>
    [Serializable]
   public class User
    {
        #region Свойства
        /// <summary>
        /// Имя.
        /// </summary>
        
        public string Name { get;}
        /// <summary>
        /// Пол.
        /// </summary>
     
        public Gender Gender { get; }
        /// <summary>
        /// Дата рождения.
        /// </summary>
        public DateTime BirthDate { get; }
        /// <summary>
        /// Вес.
        /// </summary>
        public double Weight { get; set; }
        /// <summary>
        /// Рост.
        /// </summary>
        public double Height { get; set; }
        #endregion
        /// <summary>
        /// Создать нового пользователя
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="Gender">Пол.</param>
        /// <param name="birthDate">Дата рождения.</param>
        /// <param name="weight">Вес.</param>
        /// <param name="height">Рост.</param>
        public User(string name ,
            Gender Gender,
            DateTime birthDate,
            double weight,
            double height)
        {
            #region Проверка условий
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пользователя не может быть пустым или нул", nameof(name));
            }
            if(Gender == null)
            {
                throw new ArgumentNullException("Пол не может быть нул", nameof(Gender));

            }
            if (birthDate < DateTime.Parse("01.01.1900") || birthDate >= DateTime.Now)
            {
                throw new ArgumentNullException("Невозможная дата рождения ", nameof(birthDate));

            }
            if(weight <= 0)
            {
                throw new ArgumentException("Вес не может быть равен нулю ",nameof(weight));

            }
            if(height <= 0)
            {
                throw new ArgumentException("Рост не может быть равен нулю ",nameof(height));
            }
            #endregion
            Name = name;
            BirthDate = birthDate;
            Height = height;
            Weight = weight;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
