#include "isogram.h"
#include <string.h>
#include <ctype.h>

bool is_isogram(const char phrase[])
{
    if (phrase == NULL)
        return false;
    else if (strlen(phrase) == 0)
        return true;
    
    bool charactersPresent[26] = { false };

    for (int i = 0; i < (int) strlen(phrase); ++i)
    {
        char letter = tolower(phrase[i]);

        if (letter >= 'a' && letter <= 'z')
        {
            if (charactersPresent[letter - 'a'] == false)
                charactersPresent[letter - 'a'] = true;
            else
                return false;
        }
    }
    return true;
}

