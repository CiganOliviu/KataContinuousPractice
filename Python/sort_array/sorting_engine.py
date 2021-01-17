class ISortEngine:

    def sort_array(self, array: list) -> list:
        pass


class SortEngine(ISortEngine):

    def sort_array(self, array: list) -> list:

        result = array

        for it in range(0, len(result), 1):
            for jit in range(it, len(result), 1):
                if result[it] > result[jit]:
                    result[it], result[jit] = result[jit], result[it]

        return result

