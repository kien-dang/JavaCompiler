// This code was generated by the Gardens Point Parser Generator
// Copyright (c) Wayne Kelly, John Gough, QUT 2005-2014
// (see accompanying GPPGcopyright.rtf)

// GPPG version 1.5.2
// Machine:  LAPTOP-V2TTC46J
// DateTime: 19/05/2017 3:27:32 PM
// UserName: HSBaek
// Input file <parser.y - 19/05/2017 3:19:28 PM>

// options: lines gplex

using System;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using System.Globalization;
using System.Text;
using QUT.Gppg;

namespace M11J1
{
public enum Tokens {
    error=127,EOF=128,IntegerLiteral=129,Identifier=130,FloatingPointLiteral=131,CharacterLiteral=132,
    Abstract=133,Assert=134,Boolean=135,Break=136,Byte=137,Case=138,
    Catch=139,Char=140,Class=141,Const=142,Continue=143,Default=144,
    Do=145,Double=146,Else=147,Enum=148,Extends=149,Final=150,
    Finally=151,Float=152,For=153,Goto=154,If=155,Implements=156,
    Import=157,InstanceOf=158,Int=159,Interface=160,Long=161,Native=162,
    New=163,Package=164,Private=165,Protected=166,Public=167,Return=168,
    Short=169,Static=170,Strictfp=171,Super=172,Switch=173,Synchronized=174,
    This=175,Throw=176,Throws=177,Transient=178,Try=179,Void=180,
    Volatile=181,While=182,BooleanLiteral=183,NullLiteral=184,StringLiteral=185,VariableArguments=186,
    DoubleColon=187,Selection=188,Equal=189,GreaterOrEqual=190,LessOrEqual=191,NotEqual=192,
    AndCondition=193,OrCondition=194,Increment=195,Decrement=196,SignedLeftShift=197,SignedRightShift=198,
    UnsignedRightShift=199,AddAnd=200,SubtractAnd=201,MultiplyAnd=202,DivideAnd=203,BitwiseAnd=204,
    BitwiseInclusiveOr=205,BitwiseExclusiveOr=206,ModulusAnd=207,LeftShiftAnd=208,RightShiftAnd=209,ShiftRightZeroFill=210,
    NoElse=211};

public struct ValueType
#line 8 "parser.y"
{
	public AST.CompilationUnit cu;
	public AST.ClassDeclaration cd;
	public AST.MethodHeader methodHeader;
	public AST.MethodDeclarator methodDeclarator;
	public AST.Modifier modifier;
	public AST.MethodDeclaration methodDeclaration;
	public AST.Parameter parameter;
	public List<AST.Modifier> modifiers;
	public List<AST.MethodDeclaration> methodDeclarations;
	public List<AST.Parameter> parameters;
	public List<AST.Statement> statements;
	public List<string> listString;
	public List<AST.VariableDeclaration> variableList;
	public AST.CompoundStatement compoundStatement;
	public AST.VariableDeclarationList variableDeclarationList;
	public AST.Type programType;
	public AST.VariableDeclaration variableDeclaration;
	public AST.Statement statement;
	public AST.Expression expression;

    public int num;
    public string name;
	public float fl;
	public char c;
}
#line default
// Abstract base class for GPLEX scanners
[GeneratedCodeAttribute( "Gardens Point Parser Generator", "1.5.2")]
public abstract class ScanBase : AbstractScanner<ValueType,LexLocation> {
  private LexLocation __yylloc = new LexLocation();
  public override LexLocation yylloc { get { return __yylloc; } set { __yylloc = value; } }
  protected virtual bool yywrap() { return true; }
}

// Utility class for encapsulating token information
[GeneratedCodeAttribute( "Gardens Point Parser Generator", "1.5.2")]
public class ScanObj {
  public int token;
  public ValueType yylval;
  public LexLocation yylloc;
  public ScanObj( int t, ValueType val, LexLocation loc ) {
    this.token = t; this.yylval = val; this.yylloc = loc;
  }
}

[GeneratedCodeAttribute( "Gardens Point Parser Generator", "1.5.2")]
public class Parser: ShiftReduceParser<ValueType, LexLocation>
{
  // Verbatim content from parser.y - 19/05/2017 3:19:28 PM
#line 4 "parser.y"
	public static AST.CompilationUnit Root;
#line default
  // End verbatim content from parser.y - 19/05/2017 3:19:28 PM

#pragma warning disable 649
  private static Dictionary<int, string> aliases;
#pragma warning restore 649
  private static Rule[] rules = new Rule[82];
  private static State[] states = new State[125];
  private static string[] nonTerms = new string[] {
      "ClassDeclaration", "NormalClassDeclaration", "Modifier", "Modifiers", 
      "MethodDeclaration", "ClassMemberDeclaration", "ClassBodyDeclaration", 
      "ClassBody", "ClassBodyDeclarations", "MethodHeader", "Result", "UnannType", 
      "UnannPrimitiveType", "UnannReferenceType", "NumericType", "UnannArrayType", 
      "UnannTypeVariable", "MethodDeclarator", "FormalParameterList", "FormalParameter", 
      "VariableDeclaratorId", "VariableDeclarator", "BlockStatements", "MethodBody", 
      "Block", "BlockStatement", "Statement", "SelectionStatement", "BasicLoopStatement", 
      "VariableDeclaratorList", "CommaVariableDeclarator_opt", "Assignment", 
      "LeftHandSide", "Expression", "AssignmentExpression", "Literal", "ExpressionName", 
      "ConditionalExpression", "PreIncrementExpression", "PreDecrementExpression", 
      "PostIncrementExpression", "PostDecrementExpression", "LocalVariableDeclaration", 
      "LocalVariableDeclarationStatement", "CompilationUnit", "$accept", "VariableModifiers", 
      "VariableInitializer", "AssignmentOperator", "Dims_opt", "Dims", };

  static Parser() {
    states[0] = new State(-26,new int[]{-45,1,-1,3,-2,4,-4,5});
    states[1] = new State(new int[]{128,2});
    states[2] = new State(-1);
    states[3] = new State(-2);
    states[4] = new State(-3);
    states[5] = new State(new int[]{141,6,167,80,166,81,150,82,170,83},new int[]{-3,110});
    states[6] = new State(new int[]{130,7});
    states[7] = new State(new int[]{123,9},new int[]{-8,8});
    states[8] = new State(-4);
    states[9] = new State(-6,new int[]{-9,10});
    states[10] = new State(new int[]{125,11,59,124,180,-26,159,-26,135,-26,130,-26,167,-26,166,-26,150,-26,170,-26},new int[]{-7,12,-6,13,-5,14,-4,15});
    states[11] = new State(-5);
    states[12] = new State(-7);
    states[13] = new State(-8);
    states[14] = new State(-9);
    states[15] = new State(new int[]{180,122,159,68,135,69,130,79,167,80,166,81,150,82,170,83},new int[]{-10,16,-3,110,-11,111,-12,123,-13,66,-15,67,-14,70,-16,71,-17,72});
    states[16] = new State(new int[]{123,19,59,109},new int[]{-24,17,-25,18});
    states[17] = new State(-11);
    states[18] = new State(-13);
    states[19] = new State(-17,new int[]{-23,20});
    states[20] = new State(new int[]{125,21,159,68,135,69,130,74,167,80,166,81,150,82,170,83,155,90,123,19,153,100},new int[]{-26,22,-44,23,-43,24,-12,26,-13,66,-15,67,-14,70,-16,71,-17,72,-47,75,-3,84,-27,85,-32,86,-33,88,-37,43,-28,89,-25,98,-29,99});
    states[21] = new State(-15);
    states[22] = new State(-16);
    states[23] = new State(-18);
    states[24] = new State(new int[]{59,25});
    states[25] = new State(-20);
    states[26] = new State(new int[]{130,60},new int[]{-30,27,-22,28,-21,32});
    states[27] = new State(-21);
    states[28] = new State(-37,new int[]{-31,29});
    states[29] = new State(new int[]{44,30,59,-36});
    states[30] = new State(new int[]{130,60},new int[]{-22,31,-21,32});
    states[31] = new State(-38);
    states[32] = new State(new int[]{61,33,44,-39,59,-39});
    states[33] = new State(new int[]{129,38,130,44,195,49,196,52},new int[]{-48,34,-34,35,-35,36,-36,37,-32,39,-33,40,-37,43,-38,47,-39,48,-40,51,-41,54,-42,55});
    states[34] = new State(-40);
    states[35] = new State(-41);
    states[36] = new State(-53);
    states[37] = new State(-60);
    states[38] = new State(-66);
    states[39] = new State(-61);
    states[40] = new State(new int[]{60,56,61,58,43,59},new int[]{-49,41});
    states[41] = new State(new int[]{129,38,130,44,195,49,196,52},new int[]{-34,42,-35,36,-36,37,-32,39,-33,40,-37,43,-38,47,-39,48,-40,51,-41,54,-42,55});
    states[42] = new State(-49);
    states[43] = new State(-50);
    states[44] = new State(new int[]{196,45,195,46,60,-67,61,-67,43,-67});
    states[45] = new State(-65);
    states[46] = new State(-64);
    states[47] = new State(-54);
    states[48] = new State(-55);
    states[49] = new State(new int[]{130,50});
    states[50] = new State(-62);
    states[51] = new State(-56);
    states[52] = new State(new int[]{130,53});
    states[53] = new State(-63);
    states[54] = new State(-57);
    states[55] = new State(-58);
    states[56] = new State(new int[]{129,38,130,44,195,49,196,52},new int[]{-34,57,-35,36,-36,37,-32,39,-33,40,-37,43,-38,47,-39,48,-40,51,-41,54,-42,55});
    states[57] = new State(-59);
    states[58] = new State(-51);
    states[59] = new State(-52);
    states[60] = new State(new int[]{91,63,61,-78,44,-78,59,-78,41,-78,159,-78,135,-78,130,-78,167,-78,166,-78,150,-78,170,-78},new int[]{-50,61,-51,62});
    states[61] = new State(-77);
    states[62] = new State(-79);
    states[63] = new State(new int[]{93,64});
    states[64] = new State(new int[]{91,63,61,-80,44,-80,59,-80,41,-80,159,-80,135,-80,130,-80,167,-80,166,-80,150,-80,170,-80,123,-80},new int[]{-51,65});
    states[65] = new State(-81);
    states[66] = new State(-31);
    states[67] = new State(-33);
    states[68] = new State(-35);
    states[69] = new State(-34);
    states[70] = new State(-32);
    states[71] = new State(-74);
    states[72] = new State(new int[]{91,63},new int[]{-51,73});
    states[73] = new State(-75);
    states[74] = new State(new int[]{91,-76,61,-67,43,-67});
    states[75] = new State(new int[]{159,68,135,69,130,79,167,80,166,81,150,82,170,83},new int[]{-12,76,-3,78,-13,66,-15,67,-14,70,-16,71,-17,72});
    states[76] = new State(new int[]{130,60},new int[]{-30,77,-22,28,-21,32});
    states[77] = new State(-22);
    states[78] = new State(-24);
    states[79] = new State(-76);
    states[80] = new State(-27);
    states[81] = new State(-28);
    states[82] = new State(-29);
    states[83] = new State(-30);
    states[84] = new State(-23);
    states[85] = new State(-19);
    states[86] = new State(new int[]{59,87});
    states[87] = new State(-42);
    states[88] = new State(new int[]{61,58,43,59},new int[]{-49,41});
    states[89] = new State(-43);
    states[90] = new State(new int[]{40,91});
    states[91] = new State(new int[]{129,38,130,44,195,49,196,52},new int[]{-34,92,-35,36,-36,37,-32,39,-33,40,-37,43,-38,47,-39,48,-40,51,-41,54,-42,55});
    states[92] = new State(new int[]{41,93});
    states[93] = new State(new int[]{130,97,155,90,123,19,153,100},new int[]{-27,94,-32,86,-33,88,-37,43,-28,89,-25,98,-29,99});
    states[94] = new State(new int[]{147,95,125,-46,159,-46,135,-46,130,-46,167,-46,166,-46,150,-46,170,-46,155,-46,123,-46,153,-46});
    states[95] = new State(new int[]{130,97,155,90,123,19,153,100},new int[]{-27,96,-32,86,-33,88,-37,43,-28,89,-25,98,-29,99});
    states[96] = new State(-47);
    states[97] = new State(-67);
    states[98] = new State(-44);
    states[99] = new State(-45);
    states[100] = new State(new int[]{40,101});
    states[101] = new State(new int[]{159,68,135,69,130,79,167,80,166,81,150,82,170,83},new int[]{-43,102,-12,26,-13,66,-15,67,-14,70,-16,71,-17,72,-47,75,-3,84});
    states[102] = new State(new int[]{59,103});
    states[103] = new State(new int[]{129,38,130,44,195,49,196,52},new int[]{-34,104,-35,36,-36,37,-32,39,-33,40,-37,43,-38,47,-39,48,-40,51,-41,54,-42,55});
    states[104] = new State(new int[]{59,105});
    states[105] = new State(new int[]{129,38,130,44,195,49,196,52},new int[]{-34,106,-35,36,-36,37,-32,39,-33,40,-37,43,-38,47,-39,48,-40,51,-41,54,-42,55});
    states[106] = new State(new int[]{41,107});
    states[107] = new State(new int[]{130,97,155,90,123,19,153,100},new int[]{-27,108,-32,86,-33,88,-37,43,-28,89,-25,98,-29,99});
    states[108] = new State(-48);
    states[109] = new State(-14);
    states[110] = new State(-25);
    states[111] = new State(new int[]{130,113},new int[]{-18,112});
    states[112] = new State(-12);
    states[113] = new State(new int[]{40,114});
    states[114] = new State(-71,new int[]{-19,115});
    states[115] = new State(new int[]{41,116,159,-26,135,-26,130,-26,167,-26,166,-26,150,-26,170,-26},new int[]{-20,118,-4,119});
    states[116] = new State(new int[]{91,63,123,-78,59,-78},new int[]{-50,117,-51,62});
    states[117] = new State(-70);
    states[118] = new State(-72);
    states[119] = new State(new int[]{159,68,135,69,130,79,167,80,166,81,150,82,170,83},new int[]{-12,120,-3,110,-13,66,-15,67,-14,70,-16,71,-17,72});
    states[120] = new State(new int[]{130,60},new int[]{-21,121});
    states[121] = new State(-73);
    states[122] = new State(-68);
    states[123] = new State(-69);
    states[124] = new State(-10);

    for (int sNo = 0; sNo < states.Length; sNo++) states[sNo].number = sNo;

    rules[1] = new Rule(-46, new int[]{-45,128});
    rules[2] = new Rule(-45, new int[]{-1});
    rules[3] = new Rule(-1, new int[]{-2});
    rules[4] = new Rule(-2, new int[]{-4,141,130,-8});
    rules[5] = new Rule(-8, new int[]{123,-9,125});
    rules[6] = new Rule(-9, new int[]{});
    rules[7] = new Rule(-9, new int[]{-9,-7});
    rules[8] = new Rule(-7, new int[]{-6});
    rules[9] = new Rule(-6, new int[]{-5});
    rules[10] = new Rule(-6, new int[]{59});
    rules[11] = new Rule(-5, new int[]{-4,-10,-24});
    rules[12] = new Rule(-10, new int[]{-11,-18});
    rules[13] = new Rule(-24, new int[]{-25});
    rules[14] = new Rule(-24, new int[]{59});
    rules[15] = new Rule(-25, new int[]{123,-23,125});
    rules[16] = new Rule(-23, new int[]{-23,-26});
    rules[17] = new Rule(-23, new int[]{});
    rules[18] = new Rule(-26, new int[]{-44});
    rules[19] = new Rule(-26, new int[]{-27});
    rules[20] = new Rule(-44, new int[]{-43,59});
    rules[21] = new Rule(-43, new int[]{-12,-30});
    rules[22] = new Rule(-43, new int[]{-47,-12,-30});
    rules[23] = new Rule(-47, new int[]{-3});
    rules[24] = new Rule(-47, new int[]{-47,-3});
    rules[25] = new Rule(-4, new int[]{-4,-3});
    rules[26] = new Rule(-4, new int[]{});
    rules[27] = new Rule(-3, new int[]{167});
    rules[28] = new Rule(-3, new int[]{166});
    rules[29] = new Rule(-3, new int[]{150});
    rules[30] = new Rule(-3, new int[]{170});
    rules[31] = new Rule(-12, new int[]{-13});
    rules[32] = new Rule(-12, new int[]{-14});
    rules[33] = new Rule(-13, new int[]{-15});
    rules[34] = new Rule(-13, new int[]{135});
    rules[35] = new Rule(-15, new int[]{159});
    rules[36] = new Rule(-30, new int[]{-22,-31});
    rules[37] = new Rule(-31, new int[]{});
    rules[38] = new Rule(-31, new int[]{-31,44,-22});
    rules[39] = new Rule(-22, new int[]{-21});
    rules[40] = new Rule(-22, new int[]{-21,61,-48});
    rules[41] = new Rule(-48, new int[]{-34});
    rules[42] = new Rule(-27, new int[]{-32,59});
    rules[43] = new Rule(-27, new int[]{-28});
    rules[44] = new Rule(-27, new int[]{-25});
    rules[45] = new Rule(-27, new int[]{-29});
    rules[46] = new Rule(-28, new int[]{155,40,-34,41,-27});
    rules[47] = new Rule(-28, new int[]{155,40,-34,41,-27,147,-27});
    rules[48] = new Rule(-29, new int[]{153,40,-43,59,-34,59,-34,41,-27});
    rules[49] = new Rule(-32, new int[]{-33,-49,-34});
    rules[50] = new Rule(-33, new int[]{-37});
    rules[51] = new Rule(-49, new int[]{61});
    rules[52] = new Rule(-49, new int[]{43});
    rules[53] = new Rule(-34, new int[]{-35});
    rules[54] = new Rule(-34, new int[]{-38});
    rules[55] = new Rule(-34, new int[]{-39});
    rules[56] = new Rule(-34, new int[]{-40});
    rules[57] = new Rule(-34, new int[]{-41});
    rules[58] = new Rule(-34, new int[]{-42});
    rules[59] = new Rule(-38, new int[]{-33,60,-34});
    rules[60] = new Rule(-35, new int[]{-36});
    rules[61] = new Rule(-35, new int[]{-32});
    rules[62] = new Rule(-39, new int[]{195,130});
    rules[63] = new Rule(-40, new int[]{196,130});
    rules[64] = new Rule(-42, new int[]{130,195});
    rules[65] = new Rule(-41, new int[]{130,196});
    rules[66] = new Rule(-36, new int[]{129});
    rules[67] = new Rule(-37, new int[]{130});
    rules[68] = new Rule(-11, new int[]{180});
    rules[69] = new Rule(-11, new int[]{-12});
    rules[70] = new Rule(-18, new int[]{130,40,-19,41,-50});
    rules[71] = new Rule(-19, new int[]{});
    rules[72] = new Rule(-19, new int[]{-19,-20});
    rules[73] = new Rule(-20, new int[]{-4,-12,-21});
    rules[74] = new Rule(-14, new int[]{-16});
    rules[75] = new Rule(-16, new int[]{-17,-51});
    rules[76] = new Rule(-17, new int[]{130});
    rules[77] = new Rule(-21, new int[]{130,-50});
    rules[78] = new Rule(-50, new int[]{});
    rules[79] = new Rule(-50, new int[]{-51});
    rules[80] = new Rule(-51, new int[]{91,93});
    rules[81] = new Rule(-51, new int[]{91,93,-51});
  }

  protected override void Initialize() {
    this.InitSpecialTokens((int)Tokens.error, (int)Tokens.EOF);
    this.InitStates(states);
    this.InitRules(rules);
    this.InitNonTerminals(nonTerms);
  }

  protected override void DoAction(int action)
  {
#pragma warning disable 162, 1522
    switch (action)
    {
      case 2: // CompilationUnit -> ClassDeclaration
#line 77 "parser.y"
                             { Root = ValueStack[ValueStack.Depth-1].cu; }
#line default
        break;
      case 3: // ClassDeclaration -> NormalClassDeclaration
#line 81 "parser.y"
                                 { CurrentSemanticValue.cu = new AST.CompilationUnit(ValueStack[ValueStack.Depth-1].cd); }
#line default
        break;
      case 4: // NormalClassDeclaration -> Modifiers, Class, Identifier, ClassBody
#line 85 "parser.y"
                                            { CurrentSemanticValue.cd = new AST.ClassDeclaration(ValueStack[ValueStack.Depth-4].modifiers, ValueStack[ValueStack.Depth-2].name, ValueStack[ValueStack.Depth-1].methodDeclarations); }
#line default
        break;
      case 5: // ClassBody -> '{', ClassBodyDeclarations, '}'
#line 89 "parser.y"
                                       { CurrentSemanticValue.methodDeclarations = ValueStack[ValueStack.Depth-2].methodDeclarations; }
#line default
        break;
      case 6: // ClassBodyDeclarations -> /* empty */
#line 93 "parser.y"
                         { CurrentSemanticValue.methodDeclarations = new List<AST.MethodDeclaration>(); }
#line default
        break;
      case 7: // ClassBodyDeclarations -> ClassBodyDeclarations, ClassBodyDeclaration
#line 94 "parser.y"
                                                { CurrentSemanticValue.methodDeclarations = ValueStack[ValueStack.Depth-2].methodDeclarations; CurrentSemanticValue.methodDeclarations.Add(ValueStack[ValueStack.Depth-1].methodDeclaration); }
#line default
        break;
      case 8: // ClassBodyDeclaration -> ClassMemberDeclaration
#line 98 "parser.y"
                                 { CurrentSemanticValue.methodDeclaration = ValueStack[ValueStack.Depth-1].methodDeclaration; }
#line default
        break;
      case 9: // ClassMemberDeclaration -> MethodDeclaration
#line 102 "parser.y"
                              { CurrentSemanticValue.methodDeclaration = ValueStack[ValueStack.Depth-1].methodDeclaration; }
#line default
        break;
      case 11: // MethodDeclaration -> Modifiers, MethodHeader, MethodBody
#line 107 "parser.y"
                                          { CurrentSemanticValue.methodDeclaration = new AST.MethodDeclaration(ValueStack[ValueStack.Depth-3].modifiers, ValueStack[ValueStack.Depth-2].methodHeader, ValueStack[ValueStack.Depth-1].compoundStatement); }
#line default
        break;
      case 12: // MethodHeader -> Result, MethodDeclarator
#line 111 "parser.y"
                                  { CurrentSemanticValue.methodHeader = new AST.MethodHeader(ValueStack[ValueStack.Depth-2].programType, ValueStack[ValueStack.Depth-1].methodDeclarator); }
#line default
        break;
      case 13: // MethodBody -> Block
#line 115 "parser.y"
                     { CurrentSemanticValue.compoundStatement = ValueStack[ValueStack.Depth-1].compoundStatement; }
#line default
        break;
      case 15: // Block -> '{', BlockStatements, '}'
#line 120 "parser.y"
                                  { CurrentSemanticValue.compoundStatement = new AST.CompoundStatement(ValueStack[ValueStack.Depth-2].statements); }
#line default
        break;
      case 16: // BlockStatements -> BlockStatements, BlockStatement
#line 124 "parser.y"
                                        { CurrentSemanticValue.statements = ValueStack[ValueStack.Depth-2].statements; CurrentSemanticValue.statements.Add(ValueStack[ValueStack.Depth-1].statement); }
#line default
        break;
      case 17: // BlockStatements -> /* empty */
#line 125 "parser.y"
                         { CurrentSemanticValue.statements = new List<AST.Statement>(); }
#line default
        break;
      case 18: // BlockStatement -> LocalVariableDeclarationStatement
#line 129 "parser.y"
                                          { CurrentSemanticValue.statement = ValueStack[ValueStack.Depth-1].variableDeclarationList; }
#line default
        break;
      case 19: // BlockStatement -> Statement
#line 130 "parser.y"
                        { CurrentSemanticValue.statement = ValueStack[ValueStack.Depth-1].statement; }
#line default
        break;
      case 20: // LocalVariableDeclarationStatement -> LocalVariableDeclaration, ';'
#line 134 "parser.y"
                                      { CurrentSemanticValue.variableDeclarationList = new AST.VariableDeclarationList(ValueStack[ValueStack.Depth-2].variableList); }
#line default
        break;
      case 21: // LocalVariableDeclaration -> UnannType, VariableDeclaratorList
#line 138 "parser.y"
                                         { 
																CurrentSemanticValue.variableList = new List<AST.VariableDeclaration>();
																foreach(var variableName in ValueStack[ValueStack.Depth-1].listString)
																{
																	CurrentSemanticValue.variableList.Add(new AST.VariableDeclaration(ValueStack[ValueStack.Depth-2].programType, variableName));
																}
															}
#line default
        break;
      case 25: // Modifiers -> Modifiers, Modifier
#line 154 "parser.y"
                               { CurrentSemanticValue.modifiers = ValueStack[ValueStack.Depth-2].modifiers; CurrentSemanticValue.modifiers.Add(ValueStack[ValueStack.Depth-1].modifier); }
#line default
        break;
      case 26: // Modifiers -> /* empty */
#line 155 "parser.y"
                         { CurrentSemanticValue.modifiers = new List<AST.Modifier>(); }
#line default
        break;
      case 27: // Modifier -> Public
#line 159 "parser.y"
                     { CurrentSemanticValue.modifier = AST.Modifier.Public; }
#line default
        break;
      case 28: // Modifier -> Protected
#line 160 "parser.y"
                        { CurrentSemanticValue.modifier = AST.Modifier.Protected; }
#line default
        break;
      case 29: // Modifier -> Final
#line 161 "parser.y"
                     { CurrentSemanticValue.modifier = AST.Modifier.Final; }
#line default
        break;
      case 30: // Modifier -> Static
#line 162 "parser.y"
                     { CurrentSemanticValue.modifier = AST.Modifier.Static; }
#line default
        break;
      case 31: // UnannType -> UnannPrimitiveType
#line 166 "parser.y"
                              { CurrentSemanticValue.programType = ValueStack[ValueStack.Depth-1].programType; }
#line default
        break;
      case 32: // UnannType -> UnannReferenceType
#line 167 "parser.y"
                              { CurrentSemanticValue.programType = ValueStack[ValueStack.Depth-1].programType; }
#line default
        break;
      case 33: // UnannPrimitiveType -> NumericType
#line 171 "parser.y"
                         { CurrentSemanticValue.programType = ValueStack[ValueStack.Depth-1].programType; }
#line default
        break;
      case 35: // NumericType -> Int
#line 176 "parser.y"
                   { CurrentSemanticValue.programType = new AST.IntType(); }
#line default
        break;
      case 36: // VariableDeclaratorList -> VariableDeclarator, CommaVariableDeclarator_opt
#line 180 "parser.y"
                                                   { 
																CurrentSemanticValue.listString = new List<string>();
																CurrentSemanticValue.listString.Add(ValueStack[ValueStack.Depth-2].name);
																foreach(var variable in ValueStack[ValueStack.Depth-1].listString)
																{
																	CurrentSemanticValue.listString.Add(variable);
																}
															}
#line default
        break;
      case 37: // CommaVariableDeclarator_opt -> /* empty */
#line 191 "parser.y"
                         { CurrentSemanticValue.listString = new List<string>(); }
#line default
        break;
      case 38: // CommaVariableDeclarator_opt -> CommaVariableDeclarator_opt, ',', 
               //                                VariableDeclarator
#line 192 "parser.y"
                                                       { CurrentSemanticValue.listString = ValueStack[ValueStack.Depth-3].listString; CurrentSemanticValue.listString.Add(ValueStack[ValueStack.Depth-1].name); }
#line default
        break;
      case 39: // VariableDeclarator -> VariableDeclaratorId
#line 196 "parser.y"
                                { CurrentSemanticValue.name = ValueStack[ValueStack.Depth-1].name; }
#line default
        break;
      case 42: // Statement -> Assignment, ';'
#line 205 "parser.y"
                           { CurrentSemanticValue.statement = new AST.ExpressionStatement(ValueStack[ValueStack.Depth-2].expression); }
#line default
        break;
      case 43: // Statement -> SelectionStatement
#line 206 "parser.y"
                              { CurrentSemanticValue.statement = ValueStack[ValueStack.Depth-1].statement; }
#line default
        break;
      case 44: // Statement -> Block
#line 207 "parser.y"
                     { CurrentSemanticValue.statement = ValueStack[ValueStack.Depth-1].compoundStatement; }
#line default
        break;
      case 45: // Statement -> BasicLoopStatement
#line 208 "parser.y"
                               { CurrentSemanticValue.statement = ValueStack[ValueStack.Depth-1].statement; }
#line default
        break;
      case 47: // SelectionStatement -> If, '(', Expression, ')', Statement, Else, Statement
#line 213 "parser.y"
                                                   { CurrentSemanticValue.statement = new AST.IfThenElseStatement(ValueStack[ValueStack.Depth-5].expression, ValueStack[ValueStack.Depth-3].statement, ValueStack[ValueStack.Depth-1].statement); }
#line default
        break;
      case 49: // Assignment -> LeftHandSide, AssignmentOperator, Expression
#line 221 "parser.y"
                                                { CurrentSemanticValue.expression = new AST.AssignmentExpression(ValueStack[ValueStack.Depth-3].expression, ValueStack[ValueStack.Depth-1].expression); }
#line default
        break;
      case 50: // LeftHandSide -> ExpressionName
#line 225 "parser.y"
                           { CurrentSemanticValue.expression = ValueStack[ValueStack.Depth-1].expression; }
#line default
        break;
      case 53: // Expression -> AssignmentExpression
#line 235 "parser.y"
                                { CurrentSemanticValue.expression = ValueStack[ValueStack.Depth-1].expression; }
#line default
        break;
      case 54: // Expression -> ConditionalExpression
#line 236 "parser.y"
                                 { CurrentSemanticValue.expression = ValueStack[ValueStack.Depth-1].expression; }
#line default
        break;
      case 55: // Expression -> PreIncrementExpression
#line 237 "parser.y"
                                 { CurrentSemanticValue.expression = ValueStack[ValueStack.Depth-1].expression; }
#line default
        break;
      case 56: // Expression -> PreDecrementExpression
#line 238 "parser.y"
                                  { CurrentSemanticValue.expression = ValueStack[ValueStack.Depth-1].expression; }
#line default
        break;
      case 57: // Expression -> PostIncrementExpression
#line 239 "parser.y"
                                   { CurrentSemanticValue.expression = ValueStack[ValueStack.Depth-1].expression; }
#line default
        break;
      case 58: // Expression -> PostDecrementExpression
#line 240 "parser.y"
                                   { CurrentSemanticValue.expression = ValueStack[ValueStack.Depth-1].expression; }
#line default
        break;
      case 59: // ConditionalExpression -> LeftHandSide, '<', Expression
#line 244 "parser.y"
                                     { CurrentSemanticValue.expression = new AST.BinaryExpression(ValueStack[ValueStack.Depth-3].expression,'<',ValueStack[ValueStack.Depth-1].expression); }
#line default
        break;
      case 60: // AssignmentExpression -> Literal
#line 248 "parser.y"
                      { CurrentSemanticValue.expression = ValueStack[ValueStack.Depth-1].expression; }
#line default
        break;
      case 66: // Literal -> IntegerLiteral
#line 271 "parser.y"
                           { CurrentSemanticValue.expression = new AST.NumberExpression(ValueStack[ValueStack.Depth-1].num); }
#line default
        break;
      case 67: // ExpressionName -> Identifier
#line 275 "parser.y"
                        { CurrentSemanticValue.expression = new AST.IdentifierExpression(ValueStack[ValueStack.Depth-1].name); }
#line default
        break;
      case 68: // Result -> Void
#line 279 "parser.y"
                    { CurrentSemanticValue.programType = new AST.VoidType(); }
#line default
        break;
      case 70: // MethodDeclarator -> Identifier, '(', FormalParameterList, ')', Dims_opt
#line 284 "parser.y"
                                                    { CurrentSemanticValue.methodDeclarator = new AST.MethodDeclarator(ValueStack[ValueStack.Depth-5].name, ValueStack[ValueStack.Depth-3].parameters); }
#line default
        break;
      case 71: // FormalParameterList -> /* empty */
#line 288 "parser.y"
                         { CurrentSemanticValue.parameters = new List<AST.Parameter>(); }
#line default
        break;
      case 72: // FormalParameterList -> FormalParameterList, FormalParameter
#line 289 "parser.y"
                                            { CurrentSemanticValue.parameters = ValueStack[ValueStack.Depth-2].parameters; CurrentSemanticValue.parameters.Add(ValueStack[ValueStack.Depth-1].parameter); }
#line default
        break;
      case 73: // FormalParameter -> Modifiers, UnannType, VariableDeclaratorId
#line 293 "parser.y"
                                               { CurrentSemanticValue.parameter = new AST.FormalParameter(ValueStack[ValueStack.Depth-3].modifiers, ValueStack[ValueStack.Depth-2].programType, ValueStack[ValueStack.Depth-1].name); }
#line default
        break;
      case 74: // UnannReferenceType -> UnannArrayType
#line 297 "parser.y"
                           { CurrentSemanticValue.programType = ValueStack[ValueStack.Depth-1].programType; }
#line default
        break;
      case 75: // UnannArrayType -> UnannTypeVariable, Dims
#line 301 "parser.y"
                                 { CurrentSemanticValue.programType = ValueStack[ValueStack.Depth-2].programType; }
#line default
        break;
      case 76: // UnannTypeVariable -> Identifier
#line 305 "parser.y"
                        { CurrentSemanticValue.programType = new AST.IdentifierType(); }
#line default
        break;
      case 77: // VariableDeclaratorId -> Identifier, Dims_opt
#line 309 "parser.y"
                               { CurrentSemanticValue.name = ValueStack[ValueStack.Depth-2].name; }
#line default
        break;
    }
#pragma warning restore 162, 1522
  }

  protected override string TerminalToString(int terminal)
  {
    if (aliases != null && aliases.ContainsKey(terminal))
        return aliases[terminal];
    else if (((Tokens)terminal).ToString() != terminal.ToString(CultureInfo.InvariantCulture))
        return ((Tokens)terminal).ToString();
    else
        return CharToString((char)terminal);
  }

#line 323 "parser.y"

public Parser(Scanner scanner) : base(scanner)
{
}
#line default
}
}