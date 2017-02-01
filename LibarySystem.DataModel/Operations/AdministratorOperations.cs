﻿using System;

namespace LibarySystem.DataModel.Operations {

    public static class AdministratorOperations {

        public static bool LoggingIn(string login, string password) {
            using (var context = new DbContext()) {
                var account = context.Administrators.Find(login);

                if (account == null) throw new NullReferenceException("Brak użytownika w bazie danych...");

                if (account.Password == password)
                    return true;
                throw new NullReferenceException("Podano błędne hasło...");
            }
        }

    }

}