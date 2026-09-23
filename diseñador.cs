namespace SistemaOOP.Models;

public class Diseñador : Empleado
{
    public int ProyectosDiseñados { get; set; }

    public Diseñador(string? nombre, decimal salarioBase, int proyectosDiseñados)
        : base(nombre, salarioBase)
    {
        ProyectosDiseñados = proyectosDiseñados;
    }

    public override decimal CalcularSalarioTotal()
    {
        return SalarioBase + (ProyectosDiseñados * 200m);
    }
}