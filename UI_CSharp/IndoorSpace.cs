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
        extern public static IntPtr craeteRoom(double[] coords, IntPtr[] roomList, int n, bool snapmode = true);

        [DllImport("Core_CPP.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        extern public static IntPtr updateRoom(IntPtr room, double[] coords, IntPtr[] roomList, int n, bool snapmode = true);
        

        private Dictionary<int, IntPtr> rooms;
        public int createRoom(int room_id, List<double> coords)
        {

            return 0;
        }

        public int updateRoom(int room_id, List<double> coords)
        {

            return 0;
        }

        public int removeRoom(int room_id, List<double> coords)
        {

        }

        public List<KeyValuePair<int, List<double>>> readRoomList()
        {

        }

    }

}