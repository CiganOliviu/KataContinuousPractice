package getLimitsOfArray

class GetLimitsOfArray : IGetLimitsOfArray {

    override fun getMaxValueFromArray(array: IntArray) : Int {

        var max = 0

        for (item in array)
            if (max < item)
                max = item

        return max
    }

    override fun getMinValueFromArray(array: IntArray) : Int {

        var min = 0

        for (item in array)
            if (min > item)
                min = item

        return min
    }
}