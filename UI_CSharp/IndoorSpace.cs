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
        public int createRoom(int room_id, RoomCoordinate coords)
        {

            return 0;
        }

        public int updateRoom(int room_id, RoomCoordinate coords)
        {

            return 0;
        }

        public int removeRoom(int room_id, RoomCoordinate coords)
        {
            return 0;
        }

        public List<KeyValuePair<int, RoomCoordinate>> readRoomList()
        {
            return null;
        }

    }

    class RoomCoordinate
    {
        private List<KeyValuePair<int, int>> coords;

        public void pushCoord(KeyValuePair<int, int> coord)
        {

        }
    }

}