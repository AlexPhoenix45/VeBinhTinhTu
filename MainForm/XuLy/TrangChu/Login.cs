﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace XuLy.TrangChu
{

    public class Login
    {
        public bool LoginRole(string username, string password, string role)
        {
            try
            {

            var users = new DAO.SqlToLinq.Users().getAll().Where(x => x.TaiKhoan.Equals(username) && x.MatKhau.Equals(password) && x.Status == 1);

            if(users != null ) 
            {
                foreach( var user in users )
                {
                        string className = "DAO.SqlToLinq." + role;

                        Type classType = Type.GetType(className); // Lấy loại (type) của lớp

                        if (classType != null)
                        {
                            // Gọi phương thức từ loại
                            MethodInfo method = classType.GetMethod("getByIdUser", BindingFlags.Public | BindingFlags.Instance);

                            if (method != null)
                            {
                                var instance = Activator.CreateInstance(classType);// Tạo một đối tượng của lớp

                                var result = method.Invoke(instance, new object[] { user.Id });// Gọi phương thức trên đối tượng vừa tạo

                                if (role == "DocGia")
                                {
                                    Models.DocGia dg = result as Models.DocGia;
                                    if (dg != null)
                                    {
                                        Debug.WriteLine($"Id: {dg.Id}, IdUser: {dg.IdUser}, MaDocGia: {dg.MaDocGia}, Status: {dg.Status}");

                                        Models.Session.Users = user;
                                        Models.Session.Role = new DAO.SqlToLinq.Role().getAllByName(role);
                                        Models.Session.IdUserInRole = dg.Id;
                                        Models.Session.RoleCode = dg.MaDocGia;
                                        Models.Session.cd = new DAO.SqlToLinq.CaiDat().getByIdUser(Models.Session.Users.Id);

                                        return true;
                                    }
                                }

                                else if (role == "NhanVien")
                                {
                                    Models.NhanVien dg = result as Models.NhanVien;
                                    if (dg != null)
                                    {
                                        Debug.WriteLine($"Id: {dg.Id}, IdUser: {dg.IdUser}, MaDocGia: {dg.MaNhanVien}, Status: {dg.Status}");

                                        Models.Session.Users = user;
                                        Models.Session.Role = new DAO.SqlToLinq.Role().getAllByName(role);
                                        Models.Session.IdUserInRole = dg.Id;
                                        Models.Session.RoleCode = dg.MaNhanVien;
                                        Models.Session.cd = new DAO.SqlToLinq.CaiDat().getByIdUser(Models.Session.Users.Id);

                                        return true;
                                    }
                                }
                                else if (role == "Admin")
                                {
                                    Models.Admin dg = result as Models.Admin;
                                    if (dg != null)
                                    {
                                        Debug.WriteLine($"Id: {dg.Id}, IdUser: {dg.IdUser}, MaDocGia: {dg.MaAdmin}, Status: {dg.Status}");

                                        Models.Session.Users = user;
                                        Models.Session.Role = new DAO.SqlToLinq.Role().getAllByName(role);
                                        Models.Session.IdUserInRole = dg.Id;
                                        Models.Session.RoleCode = dg.MaAdmin;
                                        Models.Session.cd = new DAO.SqlToLinq.CaiDat().getByIdUser(Models.Session.Users.Id);

                                        return true;
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Không thành công: Phương thức không tồn tại");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không thành công: Lớp không tồn tại");
                        }
                    }
            }

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }


            return false;
        }
    }
}
