class ElfoNegro : Monstro
{
    public ElfoNegro() : base("Elfo Negro", 200, 3, 2, 100, 200) { }

    public override Monstro EncontrarMonstro()
    {
        return new ElfoNegro();
    }
}
