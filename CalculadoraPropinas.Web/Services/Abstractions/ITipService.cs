using CalculadoraPropinas.Web.Models;

namespace CalculadoraPropinas.Web.Services.Abstractions;

public interface ITipService
{
    public TipModel CalculateTip(TipModel model);
}