namespace EstudoFull.Data.Converter.Contract
{
    public interface IParsser<O,D>
    {
        D ParseDtoToEnt(O Origem);
        List<D> ListParseDtoToEnt(List<O> Origens);
        O ParseEntToDto(D Destino);
        List<O> ListParseEntToDt(List<D> Destinos);
    }
}
