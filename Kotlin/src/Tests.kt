import getLimitsOfArray.GetLimitsOfArray
import kotlin.test.assertTrue

fun main() {

    val arrayLimits = GetLimitsOfArray()

    val array: IntArray = intArrayOf(10, 20, 30, 40, 50)

    assertTrue(arrayLimits.getMaxValueFromArray(array) == 50)
    assert(arrayLimits.getMinValueFromArray(array) == 10)
}