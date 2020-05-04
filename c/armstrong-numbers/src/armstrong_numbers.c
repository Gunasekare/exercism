#include "armstrong_numbers.h"
#define BASE10	10

int number_of_digits (int candidate, int flag);
int calc_armstrong_number (int candidate, int digits);
int powfunc (int base, int power);


int number_of_digits(int candidate, int flag) {
	
	if (candidate < 0)
		candidate *= -1;
	
	if (candidate == 0 && flag)
		return 0;
	else if (candidate <= 0 && !flag)
		return 1 + number_of_digits (0, 1);
	else
		return 1 + number_of_digits ((candidate / BASE10), (((candidate / BASE10) == 0) ? 1 : 0));
}

int calc_armstrong_number (int candidate, int digits) {
	
	if (candidate == 0)
			return 0;
	else
		return powfunc((candidate % BASE10), digits) + calc_armstrong_number ((candidate / BASE10), digits);
}

int is_armstrong_number(int candidate) {

	return (calc_armstrong_number (candidate, number_of_digits (candidate, 0)) == candidate) ? 1 : 0;
	
}

int powfunc (int base, int power) {
	if (power == 0)
		return 1;
	else
		return base * powfunc (base, --power);
}