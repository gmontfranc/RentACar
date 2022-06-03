﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebUI.MVC.Models
{
    public class User
    {
        [JsonProperty("email")]
        [Required(ErrorMessage = "An email is required")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [JsonProperty("name")]
        [Required(ErrorMessage = "A name is required")]
        [DisplayName("Name")]
        public string Name { get; set; }
        [JsonProperty("user_id")]
        [Required(ErrorMessage = "An email is required")]
        [DisplayName("Pickup Date")]
        public string UserId { get; set; }
        [JsonProperty("last_login")]
        public DateTimeOffset LastLogin { get; set; }
    }

    public class Users
    {
        public List<User> UserList { get; set; }
    }
}
