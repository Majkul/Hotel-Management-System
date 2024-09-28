class Hotel{
    private string name;
    private int room_num;
    private List<Room> rooms;
    public Hotel (string name, int room_num){
        this.name = name;
        this.room_num = room_num;
    }
    public void giveRoom(User user, Room room){
        if (room.IsOccupied){
            throw new Exception("Room is already occupied");
        }
        else{
            user.addRoom(room);
        }
    }
}