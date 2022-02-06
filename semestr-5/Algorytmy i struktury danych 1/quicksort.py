def partition(arr, index_start, index_end):
    i = (index_start-1)
    pivot = arr[index_end]

    for j in range(index_start, index_end):

        if arr[j] <= pivot:

            i = i+1
            arr[i], arr[j] = arr[j], arr[i]

    arr[i+1], arr[index_end] = arr[index_end], arr[i+1]
    return (i+1)

def quickSort(arr, low, high):
    if len(arr) == 1:
        return arr
    if low < high:

        # pi is partitioning index, arr[p] is now
        # at right place
        pi = partition(arr, low, high)

        # Separately sort elements before
        # partition and after partition
        quickSort(arr, low, pi-1)
        quickSort(arr, pi+1, high)


# Driver code to test above
arr = [10, 7, 8, 9, 1, 5]
n = len(arr)
quickSort(arr, 0, n-1)
print("Sorted array is:")
for i in range(n):
    print("%d" % arr[i])

tab = [11, 5, 7, 2, 15, 4, 6, 12, 87, 15, 6, 45, 41,
       18, 17, 39, 24, 64, 36, 22, 17, 91, 92, 96, 97]
