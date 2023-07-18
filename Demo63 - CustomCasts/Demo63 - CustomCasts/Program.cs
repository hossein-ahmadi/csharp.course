// Demo63 - Custom implicit and explicit cast
// TOSINSO C# Mega Course

using Demo63___CustomCasts;

var holder = new ValueHolder(10);

int value = holder;

long longValue = holder;

string strValue = holder;

ValueHolder holder2 = (ValueHolder)2;