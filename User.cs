class User{
    private string firstName;
    private string LastName;
    private int id;
    private List<Room> rooms;
    public User(string firstName, string LastName, int id){
        this.firstName = firstName;
        this.LastName = LastName;
        this.id = id;
    }
    public void addRoom(Room room){
        rooms.Add(room);
    }
}