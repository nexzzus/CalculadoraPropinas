using CalculadoraPropinas.Web.Models;
using CalculadoraPropinas.Web.Services.Abstractions;

namespace CalculadoraPropinas.Web.Services;

public class TipService: ITipService
{
    public TipModel CalculateTip(TipModel model)
    {
        if (model.TotalCheck <= 0)
        {
            model.Message = "El monto total debe ser mayor a cero";
            return model;
        }

        if (model.PercentageTip is < 0 or > 100)
        {
            model.Message = "El porcentaje de propina debe ser entre 0 y 100.";
            return model;
        }

        model.Message = "Calculo realizado con éxito.";
        return model;
    }
}