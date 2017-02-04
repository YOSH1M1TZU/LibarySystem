using System;
using System.Threading.Tasks;

namespace LibarySystem.DataModel.Operations {

    public static class AdministratorOperations {

        public static async Task<bool> LogInAsync(string login, string password) {
            var result = await Task.Run(() => {
                using (var context = new DbContext()) {
                    var account = context.Administrators.Find(login);

                    if (account == null) throw new NullReferenceException("Brak użytownika w bazie danych...");

                    if (account.Password == password)
                        return true;
                    throw new NullReferenceException("Podano błędne hasło...");
                }
            });
            return result;
        }

    }

}