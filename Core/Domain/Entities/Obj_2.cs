namespace Core.Domain.Entities;

public class Obj_2 : BaseEntity
{

    public string? DataString { get; set; }
    public int DataInt { get; set; }
    public decimal DataDecimal { get; set; }
    public DateTime DataDateTime { get; set; }

    public Obj_1? Obj_1 { get; set; }
    public ICollection<Obj_3>? Objs_3 { get; set; }
    

}