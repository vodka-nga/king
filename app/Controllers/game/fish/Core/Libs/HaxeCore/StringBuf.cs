// Generated by Haxe 3.4.4

#pragma warning disable 109, 114, 219, 429, 168, 162
public class StringBuf : global::haxe.lang.HxObject {
	
	public StringBuf(global::haxe.lang.EmptyObject empty) {
	}
	
	
	public StringBuf() {
		global::StringBuf.__hx_ctor__StringBuf(this);
	}
	
	
	public static void __hx_ctor__StringBuf(global::StringBuf __hx_this) {
		__hx_this.b = new global::System.Text.StringBuilder();
	}
	
	
	public global::System.Text.StringBuilder b;
	
	
	
	public int get_length() {
		return this.b.Length;
	}
	
	
	public void @add<T>(T x) {
		this.b.Append(((string) (global::Std.@string(x)) ));
	}
	
	
	public void addSub(string s, int pos, global::haxe.lang.Null<int> len) {
		this.b.Append(((string) (s) ), ((int) (pos) ), ((int) (( ( ! (len.hasValue) ) ? (( s.Length - pos )) : ((len).@value) )) ));
	}
	
	
	public void addChar(int c) {
		this.b.Append(((char) (c) ));
	}
	
	
	public string toString() {
		return this.b.ToString();
	}
	
	
	public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
		unchecked {
			switch (hash) {
				case 98:
				{
					this.b = ((global::System.Text.StringBuilder) (@value) );
					return @value;
				}
				
				
				default:
				{
					return base.__hx_setField(field, hash, @value, handleProperties);
				}
				
			}
			
		}
	}
	
	
	public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
		unchecked {
			switch (hash) {
				case 946786476:
				{
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "toString", 946786476)) );
				}
				
				
				case 2113708439:
				{
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "addChar", 2113708439)) );
				}
				
				
				case 520665567:
				{
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "addSub", 520665567)) );
				}
				
				
				case 4846113:
				{
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "add", 4846113)) );
				}
				
				
				case 261031087:
				{
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "get_length", 261031087)) );
				}
				
				
				case 520590566:
				{
					return this.get_length();
				}
				
				
				case 98:
				{
					return this.b;
				}
				
				
				default:
				{
					return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
				}
				
			}
			
		}
	}
	
	
	public override double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties) {
		unchecked {
			switch (hash) {
				case 520590566:
				{
					return ((double) (this.get_length()) );
				}
				
				
				default:
				{
					return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
				}
				
			}
			
		}
	}
	
	
	public override object __hx_invokeField(string field, int hash, global::ArrayHaxe dynargs) {
		unchecked {
			switch (hash) {
				case 946786476:
				{
					return this.toString();
				}
				
				
				case 2113708439:
				{
					this.addChar(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
					break;
				}
				
				
				case 520665567:
				{
					this.addSub(global::haxe.lang.Runtime.toString(dynargs[0]), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), global::haxe.lang.Null<object>.ofDynamic<int>(dynargs[2]));
					break;
				}
				
				
				case 4846113:
				{
					this.@add<object>(((object) (dynargs[0]) ));
					break;
				}
				
				
				case 261031087:
				{
					return this.get_length();
				}
				
				
				default:
				{
					return base.__hx_invokeField(field, hash, dynargs);
				}
				
			}
			
			return null;
		}
	}
	
	
	public override void __hx_getFields(global::ArrayHaxe<object> baseArr) {
		baseArr.push("length");
		baseArr.push("b");
		base.__hx_getFields(baseArr);
	}
	
	
	public override string ToString(){
		return this.toString();
	}
	
	
}


