#include <string>
#include <iostream>
using namespace std;

int length(const char* str) {
    int n = 0;
    while (str[n] != '\0')n++;
    return n;
}

int max(int a, int b) {
    return a > b ? a : b;
}

int min(int a, int b) {
    return a < b ? a : b;
}

bool compare(const char* a, const char* b) {
    int len_a = length(a);
    int len_b = length(b);
    int m = min(len_a, len_b);
    for (int i = 0;i < m;i++) {
        if (a[i] > b[i])return false;
        if (a[i] < b[i])return true;
    }
    return len_a < len_b;
}

void test(string a, string b) {
    cout << a << " " << b << endl;
    cout << compare(a.c_str(), b.c_str()) << " " << (a < b) << endl;
}

int main() {
    // test("eisenhower", "einstein");
    // test("abc", "abc");
    // test("abc", "abb");
    // test("abb", "abc");
    // test("abc", "abcd");
    // test("abcd", "abc");
    // test("hfuepfl", "hfuepfl");
    // test("hfuePfl", "hfuepfl");

test("hfuePfl", "hfuepfl");
}