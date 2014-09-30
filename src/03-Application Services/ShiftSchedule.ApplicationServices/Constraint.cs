
namespace ShiftSchedule.ApplicationServices
{
    public enum DeafultConstraints
    {
        AvoidDoubleShift = 0,
        AvoidSandwiche = 1, //more than one free shift between two scheduled shifts
        MinShifts = 2,
        MaxShifts = 3
    }
    class Constraint
    {
        private string Name; //the admin of this app could create new constraints by basic logic information

    }
}
