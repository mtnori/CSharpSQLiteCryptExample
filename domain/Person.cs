using System.ComponentModel.DataAnnotations.Schema;

namespace CSharpSQLiteCryptExample.domain
{
    [Table("person")]
    public class Person
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public required string Name { get; set; }
    }

}
