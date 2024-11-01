using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    internal class Helper
    {
        private static construction_organizationEntities1 _context;

        public static construction_organizationEntities1 GetContext()
        {
            // Проверка, установлено ли подключение; если нет, создается новое подключение
            if (_context == null)
            {
                _context = new construction_organizationEntities1(); // Создание нового подключения к БД
            }
            return _context; // Возвращение текущего подключения
        }

        public void CreateUser(Logins user)
        {
            _context.Users.Add(user); // Добавление записи нового пользователя в таблицу Users
            _context.SaveChanges(); // Сохранение изменений в БД
        }

    }
}
