namespace Core.Domain.Entities;

public class Obj_3 : BaseEntity
{

    public string? DataString { get; set; }
    public int DataInt { get; set; }
    public decimal DataDecimal { get; set; }
    public DateTime DataDateTime { get; set; }

    public ICollection<Obj_2>? Objs_2 { get; set; }
}