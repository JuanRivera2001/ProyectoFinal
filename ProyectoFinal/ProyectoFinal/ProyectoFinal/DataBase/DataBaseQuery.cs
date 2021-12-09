using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.Models;

namespace ProyectoFinal.DataBase
{
    public class DataBaseQuery
    {
        readonly SQLiteAsyncConnection _database;

        public DataBaseQuery(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<UserModel>().Wait();
            _database.CreateTableAsync<RestaurantModel>().Wait();
        }

        #region CRUD
        //Update or Insert a UserModel
        public Task<int> SaveUserModelAsync(UserModel usermodel)
        {
            if (usermodel.UserID != 0)
            {
                return _database.UpdateAsync(usermodel);
            }
            else
            {
                return _database.InsertAsync(usermodel);
            }
        }

        //Get the UserModel from DB
        public Task<List<UserModel>> GetUserModel()
        {
            return _database.Table<UserModel>().ToListAsync();
        }

        //Get the Restaurant List from DB
        public Task<List<RestaurantModel>> GetRestaurantModel()
        {
            return _database.Table<RestaurantModel>().ToListAsync();
        }

        //Generic select for any model
        public Task<List<T>> GetTableModel<T>() where T : new()
        {
            return _database.Table<T>().ToListAsync();
        }

        //Generic Update and Insert for any model
        public Task<int> SaveModelAsync<T>(T model, bool isInsert) where T : new()
        {
            if (isInsert != true)
            {
                return _database.UpdateAsync(model);
            }
            else
            {
                return _database.InsertAsync(model);
            }
        }

        //Generic Delete Model from DB
        public Task<int> DeleteModelAsync<T>(T model) where T : new()
        {

            return _database.DeleteAsync(model);

        }

        //Generic execution query 
        public Task<List<T>> QueryModel<T>(string query) where T : new()
        {
            return _database.QueryAsync<T>(query);
        }

        //Validate user login using a SELECT from database
        public Task<List<UserModel>> ValidateUserModel(string email, string pw)
        {
            return _database.QueryAsync<UserModel>("SELECT * FROM UserModel WHERE Email = '" + email + "' AND Password = '" + pw + "' ");
        }

        //Change User password using a Update
        public Task<List<UserModel>> ChangeUserPassword(string email, string confirmCode ,string newPassword)
        {
            if (confirmCode.Equals("75846"))
            {
                return _database.QueryAsync<UserModel>("UPDATE UserModel SET Password ='" + newPassword + "' WHERE Email ='" 
                                                        + email +"'");
            }
            else
            {
                return _database.QueryAsync<UserModel>("SELECT 1 FROM DUAL");
            }
        }

        //Get the info for an especific user
        public Task<UserModel> GetUserModel(string email, string pw)
        {
            return _database.Table<UserModel>().Where(i => i.Email == email && i.Password == pw).FirstOrDefaultAsync();

        }

        #endregion
    }
}
