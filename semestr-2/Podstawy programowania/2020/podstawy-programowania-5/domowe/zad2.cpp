#include <iostream>
#include <vector>
#include <string>
#include <fstream>
#include <algorithm>
using namespace std;

vector<int> get_shuffled_numbers(int size)
{
    vector<int> output(size);
    for (int i = 0; i < size; i++)
    {
        output[i] = i;
    }
    random_shuffle(output.begin(), output.end());
    return output;
}

int get_position(vector<int> container, int element)
{
    for (int i = 0; i < container.size(); i++)
    {
        if (container[i] == element)
            return i;
    }
    return -1;
}

vector<string> split_data(string data, string delimiter)
{

    vector<string> output;
    size_t pos = 0;
    string token;
    while ((pos = data.find(delimiter)) != string::npos)
    {
        token = data.substr(0, pos);
        data.erase(0, pos + delimiter.length());
        output.push_back(token);
    }
    // if(data.length()>0)
    output.push_back(data);
    return output;
}

class Question
{
    string title;
    string content;
    vector<string> answers;
    int correct_answer;

public:
    Question(string data)
    {
        vector<string> elements = split_data(data, "\n\n");
        title = elements[0].substr(2, elements[0].length() - 2);
        content = elements[1];
        answers = split_data(elements[2], "\n");
        for (auto it = answers.begin(); it != answers.end(); it++)
        {
            (*it) = it->substr(3, it->length() - 3);
        }
        char answer = elements[3].substr(12, 1).c_str()[0];
        correct_answer = answer - 'a';
    }

    bool show()
    {
        cout << title << endl;
        cout << content << endl
             << endl;
        cout << "Odpowiedzi:" << endl;
        char num = 'a';

        vector<int> order = get_shuffled_numbers(answers.size());
        int correct = get_position(order, correct_answer);

        for (auto it = order.begin(); it != order.end(); it++)
        {
            int i = *it;
            cout << num << ") " << answers[i] << endl;
            num++;
        }
        char answer;
        cout << endl;
        cout << "Odpowiedź: ";
        cin >> answer;
        int answer_num = answer - 'a';

        if (answer_num == correct)
        {
            cout << "Poprawna odpowiedź!" << endl
                 << endl;
            ;
            return true;
        }
        else
        {
            cout << "Zła odpowiedź! Poprawna odpowiedź to: " << (char)('a' + correct) << "." << endl
                 << endl;
            return false;
        }
    }
};

class QuestionSet
{

    vector<Question> questions;
    int points = 0;

public:
    QuestionSet(string filename)
    {
        ifstream file;
        file.open(filename);

        string buffer;
        string zadanie;

        while (getline(file, buffer))
        {
            if (buffer.length() > 0 && buffer[0] == '#' && zadanie.length() > 0)
            {
                questions.push_back(Question(zadanie));
                zadanie = "";
            }
            zadanie += buffer + '\n';
        }
        if (zadanie.length() > 1)
            questions.push_back(Question(zadanie));

        file.close();
    }

    void show()
    {
        int correct_answers = 0;
        for (auto it = questions.begin(); it != questions.end(); it++)
        {
            bool correct = it->show();
            if (correct)
            {
                correct_answers++;
            }
        }

        cout << endl;
        cout << "Koniec testu!" << endl;
        cout << "Odpowiedzi poprawne: " << correct_answers << endl;
        cout << "Odpowiedzi niepoprawne: " << questions.size() - correct_answers << endl;
    }
};

int main()
{
    QuestionSet zadania = QuestionSet("pytania.txt");
    zadania.show();
}