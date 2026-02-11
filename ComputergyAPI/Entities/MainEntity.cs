

namespace ComputergyAPI.Entities
{
    public abstract class MainEntity
    {
        //for shared properites

        public int Id { get; set; }  //Primary Key

        public string CreatedBy { get; set; }  //nvarchar(max) not allowed to be null

        public string? UpdatedBy { get; set; }  //nvarchar(max) nullable 

        public DateTime CreationDate { get; set; }  //Datetime not null
         
        public DateTime? UpdatedDate { get; set; }  //DateTime nullable

        public bool IsActive { get; set; } = true;  //but not null with default value of true


    }
}
