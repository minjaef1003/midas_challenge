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
        public const double SNAPPING_THRES = 1.0;

        private List<KeyValuePair<int, int>> coords;

        public List<KeyValuePair<int, int>> Coords { get => coords; set => coords = value; }

        // 0 : open, 1 : close
        public int PushCoord(KeyValuePair<int, int> new_coord)
        {
            if (coords.Count > 1 && IsDone(new_coord))
            {
                // TODO : is Simple Polygon?

                return 1;
            }
            coords.Add(new_coord);
            return 0;
        }

        /**
         * Check first and last vertices
         * */
        public bool IsDone(KeyValuePair<int, int> new_coord)
        {
            KeyValuePair<int, int> firstVertex = coords[0];
            double dist = EuclideanDist(new_coord, firstVertex);
            if (dist < SNAPPING_THRES)
                return true;
            return false;
        }

        public static double EuclideanDist(KeyValuePair<int, int> coord1, KeyValuePair<int, int> coord2)
        {
            return Math.Sqrt(Math.Pow((double)(coord1.Key - coord2.Key), 2.0) + Math.Pow((double)(coord2.Value - coord1.Value), 2.0));
        }
    }

}