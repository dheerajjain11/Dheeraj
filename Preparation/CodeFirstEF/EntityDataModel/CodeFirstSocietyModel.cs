namespace EntityDataModel
{ 
    using System.Data.Entity;
    using CodeFirstEF.POCO;

    public class CodeFirstSocietyModel : DbContext
    {
        public CodeFirstSocietyModel()
            : base("name=CodeFirstSocietyModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public DbSet<ResidentialUnit> ResidentialUnits { get; set; }

        public DbSet<Society> Societies { get; set; }
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<Room> Rooms { get; set; }
    } 
}