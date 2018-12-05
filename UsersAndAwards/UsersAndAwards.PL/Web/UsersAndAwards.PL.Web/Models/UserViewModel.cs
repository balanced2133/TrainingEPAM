﻿using Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using System.Web;

namespace UsersAndAwards.PL.Web.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Birthdate { get; set; }

        public int Age { get; set; }

        public List<Award> Awards { get; set; }

        public List<AwardViewModel> AvailableAwards { get; set; }

        public UserViewModel()
        {

        }

        public UserViewModel(string fname, string lname, DateTime bdate, List<Award> awards)
        {
            FirstName = fname;
            LastName = lname;
            Birthdate = bdate;
            Awards = awards;
            AvailableAwards = new List<AwardViewModel>();
            if (awards != null)
            foreach(var award in Awards)
            {
                AvailableAwards.Add(AwardViewModel.GetViewModel(award, awards));
            }
        }

        public User ToUser(UserViewModel user1)
        {
            return new User(user1.FirstName, user1.LastName, user1.Birthdate)
            {
                Id = user1.Id,
                Awards = AvailableAwards
                    .Where(a => a.IsAssigned == true)
                    .Select(a => new Award(a.Title, a.Description)
                    {
                        AwardId = a.Id
                    }).ToList()
            };

           
        }
    }
}