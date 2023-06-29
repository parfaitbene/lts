using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LTS2.Models;
using MySql.Data.MySqlClient;

namespace LTS2.Repository
{
    class WarehouseRepository
    {
        MySqlCommand cmd;

        public Boolean save(Warehouse warehouse)
        {
            try
            {
                String query = "INSERT INTO Warehouse (code, name, description) VALUES('" + warehouse.code + "','" + warehouse.name + "','" + warehouse.description + "');";
                cmd = new MySqlCommand(query, Program.con);
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception e) { return false; }
        }

        public Boolean update(Warehouse warehouse)
        {
            try
            {
                String query = "UPDATE Warehouse SET code='" + warehouse.code + "', name='" + warehouse.name + "', description='" + warehouse.description + "' WHERE id=" + warehouse.id + ";";
                cmd = new MySqlCommand(query, Program.con);
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception e) { return false; }
        }

        public Boolean Delete(Warehouse warehouse)
        {
            try
            {
                string query = "DELETE FROM Warehouse WHERE id=" + warehouse.id + ";";
                cmd = new MySqlCommand(query, Program.con);
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception e) { return false; }
        }

        public List<Warehouse> getAll()
        {
            List<Warehouse> warehouseList = new List<Warehouse>();
            string query = "SELECT * FROM Warehouse;";
            cmd = new MySqlCommand(query, Program.con);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Warehouse w = new Warehouse((long)(dr["id"]), dr["code"].ToString(), dr["name"].ToString(), dr["description"].ToString());
                warehouseList.Add(w);
            }

            dr.Close();
            return warehouseList;
        }
    }
}
