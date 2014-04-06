#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <stdbool.h>

#define STACKSIZE 100
#define INPUTSIZE 200
#define OPENER 2
#define CLOSER 3
#define LINE "|--------|-------|------|"
#define LINEN "|--------|-------|------|\n"

typedef struct {
	int id;
	char ch;
} ITEM;

typedef struct {
	int size;
	ITEM items[STACKSIZE];
} STACK;

bool isPair(char open, char close) {
	switch(open) {
		case '(' :
			if(close==')') return true;
			return false;
			break;

		case '{' :
			if(close=='}') return true;
			return false;
			break;

		case '[' :
			if(close==']') return true;
			return false;
			break;

		default :
			return false;
			break;
	}
}

char getPair(char c) {
	switch(c) {
		case '(' :
			return ')';
			break;

		case '{' :
			return '}';
			break;

		case '[' :
			return ']';
			break;

		default :
			return 'X';
			break;
	}
}

int getType(char c) {
	switch(c) {
		case '(' :
		case '{' :
		case '[' :
			return OPENER;
			break;

		case ')' :
		case '}' :
		case ']' :
			return CLOSER;
			break;

		default :
			return 0;
			break;
	}
}

STACK* initStack(STACK *ps) {
	ps = (STACK*)malloc(sizeof(STACK));
	ps->size = 0;
	return ps;
}

bool isStackEmpty(STACK *ps) {
	if(ps->size == 0) return true;
	return false;
}

bool isStackFull(STACK *ps) {
	if(ps->size==STACKSIZE) return true;
	return false;
}

void push(STACK *ps, ITEM x) {
	if(isStackFull(ps)) {
		fprintf(stderr, "%s\tError : Stack Overflow\n", LINE);
		return;
	}
	ps->items[ps->size] = x;
	printf("|  push\t |  %03d  |  %c%c  |\n", ps->items[ps->size].id, ps->items[ps->size].ch, getPair(ps->items[ps->size].ch));
	ps->size++;
}

ITEM pop(STACK *ps) {
	if(isStackEmpty(ps)) {
		fprintf(stderr, "%s\tError : Stack Underflow\n", LINE);
		ITEM emptyItem;
		return emptyItem;
	}
	ps->size--;
	printf("|  pop\t |  %03d  |  %c%c  |\n", ps->items[ps->size].id, ps->items[ps->size].ch, getPair(ps->items[ps->size].ch));
	return ps->items[ps->size];
}

ITEM getTop(STACK *ps) {
	return ps->items[(ps->size)-1];
}

char getTopChar(STACK *ps) {
	return ps->items[(ps->size)-1].ch;
}

int main() {
	STACK *ps;
	ps = initStack(ps);

	char mStr[INPUTSIZE];

	printf("Input : ");
	scanf("%s", &mStr);

	printf("=====    RESULTS    =====\n");
	printf("┌-----------------------┐\n");
	printf("|        | start | type |\n");
	printf("|        | point |      |\n");
	printf("|--------|-------|------|\n");

	for(int i=0;i<strlen(mStr);i++) {
		if(!getType(mStr[i])) {
			fprintf(stderr, "%s\tError : Unexpected Input - (at %d) cahracter %c\n%s\tPlease Input only (){}[]\n", LINE, i+1, mStr[i], LINE);
			return 1;
		}
		else if(getType(mStr[i])==OPENER) {
			ITEM mItem;
			mItem.id = i + 1;
			mItem.ch = mStr[i];
			push(ps, mItem);
		}
		else if(getType(mStr[i])==CLOSER) {
			if(isPair(getTopChar(ps), mStr[i])) {
				pop(ps);
			}
			else {
				fprintf(stderr, "%s\tError : Uncorrect Input\n%s\t(at %d) character %c should be replaced\n", LINE, LINE, i+1, mStr[i]);
				return 1;
			}
		}
	}

	if(ps->size!=0) {
		fprintf(stderr, "%s\tError : Unexpected End\n%s\t%c has to be closed (started at %d)\n", LINE, LINE, getTopChar(ps), getTop(ps).id);
		return 1;
	}

	printf("└-----------------------┘\n");
	printf("= SUCCESSFULLY FINISHED =\n");
	
	free(ps);
}
