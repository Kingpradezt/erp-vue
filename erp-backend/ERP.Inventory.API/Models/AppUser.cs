using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.Inventory.API.Models
{
    [Table("app_users")]
    public class AppUser
    {
        [Key]
        [Column("user_id")]
        public int UserId { get; set; }

        [Column("username")]
        public string Username { get; set; } = "";

        [Column("password_hash")]
        public string PasswordHash { get; set; } = "";

        [Column("email_address")]
        public string? EmailAddress { get; set; }

        [Column("full_name")]
        public string? FullName { get; set; }

        [Column("user_role")]
        public string? UserRole { get; set; }

        [Column("mobile_number")]
        public string? MobileNumber { get; set; }

        [Column("account_status")]
        public string? AccountStatus { get; set; }

        [Column("last_login_at")]
        public string? LastLoginAt { get; set; }

        [Column("created_at")]
        public string? CreatedAt { get; set; }

        [Column("updated_at")]
        public string? UpdatedAt { get; set; }
    }
}
