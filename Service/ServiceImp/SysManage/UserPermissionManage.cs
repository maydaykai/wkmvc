﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;
using Service.IService;

namespace Service.ServiceImp
{
    /// <summary>
    /// Service层用户授权接口
    /// add yuangang by 2016-05-19
    /// </summary>
    public class UserPermissionManage : RepositoryBase<SYS_USER_PERMISSION>, IUserPermissionManage
    {
        IPermissionManage PermissionManage { get; set; }
        /// <summary>
        /// 保存用户权限
        /// </summary>
        public bool SetUserPermission(int userId, string newper)//, string sysId)
        {
            try
            {
                ////1、获取当前系统的模块ID集合
                //var permissionId = this.PermissionManage.GetPermissionIdBySysId(sysId).Cast<int>().ToList();
                //2、获取用户权限，是否存在，存在即删除
                if (this.IsExist(p => p.FK_USERID == userId)) // && permissionId.Any(e => e == p.FK_PERMISSIONID)))
                {
                    //3、删除用户权限
                    this.Delete(p => p.FK_USERID == userId); // && permissionId.Any(e => e == p.FK_PERMISSIONID));
                }
                //4、添加用户权限
                var str = newper.Trim(',').Split(',');
                foreach (var per in str.Select(t => new Domain.SYS_USER_PERMISSION()
                {
                    FK_USERID = userId,
                    FK_PERMISSIONID = int.Parse(t)
                }))
                {
                    this._Context.Set<SYS_USER_PERMISSION>().Add(per);
                }
                //5、Save
                return this._Context.SaveChanges() > 0;
            }
            catch (Exception e) { throw e; }
        }
    }
}