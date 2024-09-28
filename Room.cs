class Room{
    private int num;
    private int space;
    private int lux;
    private bool isClean;
    private bool isOccupied;
    public bool IsOccupied{
        get { return isOccupied; }
        set { isOccupied = value; }
    }
    public Room(int num, int space, int lux){
        this.num = num;
        this.space = space;
        this.lux = lux;
        this.isClean = true;
        this.isOccupied = false;
    }
}