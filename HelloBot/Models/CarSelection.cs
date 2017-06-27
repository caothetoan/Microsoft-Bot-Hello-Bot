using System;
using System.Collections.Generic;

namespace HelloBot.Models
{
    [Serializable]
    public class CarSelection
    {
        public MultimediaEquipment Multimedia;
        public String Name;
        public CarModel Model;
        public List<CupHolderChoice> CupHolders;
    }

    public enum SeatChoice
    {
        Leather,
        Cloth
    }

    public enum CoreSystem
    {
        VideoWithGps,
        VideoOnly,
        GpsOnly,
        Basic
    }

    public enum CarModel
    {
        Basic,
        Standard,
        Premium
    }

    public enum CupHolderChoice
    {
        Tiny,
        Standard,
        Large,
        American
    }
    [Serializable]
    public class MultimediaEquipment
    {
        public CoreSystem System;
        public Int32? VideoDevices;
    }
}