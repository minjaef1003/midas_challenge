using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using midas_challenge.Geometry;

namespace midas_challenge
{
    using Coordinate = KeyValuePair<int, int>;

    class IndoorSpace
    {
        [DllImport("Core_CPP.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        extern public static IntPtr craeteRoom(int[] coords, int n1, IntPtr[] roomList, int n2);

        [DllImport("Core_CPP.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        extern public static IntPtr updateRoom(IntPtr room, int[] coords, IntPtr[] roomList, int n);

        private Dictionary<int, IntPtr> rooms;

        public int CreateRoom(int room_id, RoomCoordinate coords)
        {
            int[] coords_arr = new int[coords.Coords.Count * 2];
            for (int i = 0; i < coords.Coords.Count; i++)
            {
                coords_arr[i] = coords.Coords[i].Key;
                coords_arr[i + 1] = coords.Coords[i].Value;
            }

            IntPtr[] room_list = rooms.Values.ToArray();

            IntPtr new_room = craeteRoom(coords_arr, coords.Coords.Count, room_list, rooms.Count);
            rooms.Add(room_id, new_room);
            return 0;
        }

        public int UpdateRoom(int room_id, RoomCoordinate coords)
        {

            return 0;
        }

        public int moveRoom()
        {
            return 0;
        }

        public int RemoveRoom(int room_id, RoomCoordinate coords)
        {
            return 0;
        }

        public List<KeyValuePair<int, RoomCoordinate>> ReadRoomList()
        {
            return null;
        }

    }

    class RoomCoordinate
    {
        private IndoorSpace isp;
        RoomCoordinate(IndoorSpace _isp)
        {
            isp = _isp;
        }

        private List<Coordinate> coords = new List<Coordinate>();

        public List<Coordinate> Coords { get => coords; set => coords = value; }

        // 0 : open, 1 : close
        public int PushCoord(ref Coordinate new_coord)
        {
            snap(ref new_coord);
            if (Coords.Count > 1)
            {
                // TODO : is Simple Polygon?
                return 1;
                
            }
            Coords.Add(new_coord);
            return 0;
        }

        private void snap(ref Coordinate new_coord)
        {
            
        }

    }

}