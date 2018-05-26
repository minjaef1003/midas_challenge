using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace midas_challenge
{
    class IndoorSpace
    {
        [DllImport("Core_CPP.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        extern public static IntPtr craeteRoom(int[] coords, IntPtr[] roomList, int n, bool snapmode = true);

        [DllImport("Core_CPP.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        extern public static IntPtr updateRoom(IntPtr room, int[] coords, IntPtr[] roomList, int n, bool snapmode = true);
        

        private Dictionary<int, IntPtr> rooms;
        public int CreateRoom(int room_id, RoomCoordinate coords)
        {

            return 0;
        }

        public int UpdateRoom(int room_id, RoomCoordinate coords)
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
        private List<KeyValuePair<int, int>> coords;

        public List<KeyValuePair<int, int>> Coords { get => coords; set => coords = value; }

        // 0 : open, 1 : close
        public int PushCoord(KeyValuePair<int, int> coord)
        {
            if (IsDone())
            {

            }
            return 0;
        }

        public bool IsDone()
        {
            return false;
        }
    }

}