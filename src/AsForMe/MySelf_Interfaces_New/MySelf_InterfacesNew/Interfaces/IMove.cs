namespace MySelf_InterfacesNew.Interfaces
{
    interface IMove
    {
        const int minSpeed = 0;
        const int maxSpeed = 100;

        void Move();

        public string Name { get; set; }
    }
}