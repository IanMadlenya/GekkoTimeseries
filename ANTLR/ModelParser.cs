// $ANTLR 3.1.3 Mar 18, 2009 10:09:25 Model.g 2016-03-03 11:35:01

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;

using IDictionary	= System.Collections.IDictionary;
using Hashtable 	= System.Collections.Hashtable;

using Antlr.Runtime.Tree;

namespace  Gekko 
{
public partial class ModelParser : Parser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"LOG", 
		"EXP", 
		"FRML", 
		"AFTER", 
		"AFTER2", 
		"VAL", 
		"VARLIST", 
		"PLUS", 
		"MINUS", 
		"NEGATE", 
		"MULT", 
		"DIV", 
		"LB", 
		"RB", 
		"RP", 
		"DOT", 
		"TRUE", 
		"FALSE", 
		"ASTMODELBLOCK", 
		"ASTAFTER", 
		"ASTAFTER2", 
		"ASTASSIGNVAR", 
		"ASTINTEGER", 
		"ASTDOUBLE", 
		"ASTVARIABLE", 
		"ASTEXPRESSION", 
		"ASTFRMLCODE", 
		"ASTFUNCTION", 
		"ASTLAGFUNCTION", 
		"ASTLEFTSIDE", 
		"ASTSIMPLEFUNCTION", 
		"ASTVARIABLELAGLEAD", 
		"ASTLAGORLEAD", 
		"ASTFRML", 
		"ASTPOW", 
		"ASTVAL", 
		"ASTVARLIST", 
		"Modelblock", 
		"Double", 
		"Integer", 
		"Ident", 
		"MOD", 
		"AssignVar", 
		"STARS", 
		"HAT", 
		"DIGIT", 
		"Exponent", 
		"A", 
		"Q", 
		"M", 
		"DATE", 
		"LETTER", 
		"WHITESPACE", 
		"NEWLINE", 
		"NEWLINE2", 
		"NEWLINE3", 
		"Comment", 
		"NESTED_ML_COMMENT", 
		"B", 
		"C", 
		"D", 
		"E", 
		"F", 
		"G", 
		"H", 
		"I", 
		"J", 
		"K", 
		"L", 
		"N", 
		"O", 
		"P", 
		"R", 
		"S", 
		"T", 
		"U", 
		"V", 
		"W", 
		"X", 
		"Y", 
		"Z", 
		"'='", 
		"'('", 
		"','", 
		"'['", 
		"']'", 
		"'$'", 
		"';'"
    };

    public const int ASTPOW = 38;
    public const int ASTMODELBLOCK = 22;
    public const int ASTVARIABLE = 28;
    public const int MOD = 45;
    public const int LETTER = 55;
    public const int LOG = 4;
    public const int AFTER2 = 8;
    public const int EOF = -1;
    public const int ASTINTEGER = 26;
    public const int ASTASSIGNVAR = 25;
    public const int HAT = 48;
    public const int T__91 = 91;
    public const int T__90 = 90;
    public const int EXP = 5;
    public const int Comment = 60;
    public const int ASTVAL = 39;
    public const int VAL = 9;
    public const int Double = 42;
    public const int D = 64;
    public const int E = 65;
    public const int F = 66;
    public const int G = 67;
    public const int A = 51;
    public const int B = 62;
    public const int C = 63;
    public const int L = 72;
    public const int M = 53;
    public const int NESTED_ML_COMMENT = 61;
    public const int N = 73;
    public const int O = 74;
    public const int H = 68;
    public const int I = 69;
    public const int NEWLINE2 = 58;
    public const int J = 70;
    public const int NEWLINE3 = 59;
    public const int K = 71;
    public const int U = 79;
    public const int T = 78;
    public const int WHITESPACE = 56;
    public const int W = 81;
    public const int V = 80;
    public const int Q = 52;
    public const int P = 75;
    public const int ASTFRML = 37;
    public const int S = 77;
    public const int MULT = 14;
    public const int R = 76;
    public const int T__85 = 85;
    public const int T__87 = 87;
    public const int T__86 = 86;
    public const int T__89 = 89;
    public const int Y = 83;
    public const int T__88 = 88;
    public const int X = 82;
    public const int Z = 84;
    public const int ASTAFTER2 = 24;
    public const int Ident = 44;
    public const int ASTEXPRESSION = 29;
    public const int VARLIST = 10;
    public const int ASTLAGFUNCTION = 32;
    public const int ASTLAGORLEAD = 36;
    public const int FALSE = 21;
    public const int Modelblock = 41;
    public const int ASTSIMPLEFUNCTION = 34;
    public const int RB = 17;
    public const int RP = 18;
    public const int ASTVARIABLELAGLEAD = 35;
    public const int ASTFUNCTION = 31;
    public const int ASTAFTER = 23;
    public const int AssignVar = 46;
    public const int Exponent = 50;
    public const int ASTVARLIST = 40;
    public const int ASTFRMLCODE = 30;
    public const int PLUS = 11;
    public const int FRML = 6;
    public const int DIGIT = 49;
    public const int DOT = 19;
    public const int NEGATE = 13;
    public const int MINUS = 12;
    public const int AFTER = 7;
    public const int TRUE = 20;
    public const int ASTLEFTSIDE = 33;
    public const int NEWLINE = 57;
    public const int STARS = 47;
    public const int LB = 16;
    public const int ASTDOUBLE = 27;
    public const int DIV = 15;
    public const int DATE = 54;
    public const int Integer = 43;

    // delegates
    // delegators



        public ModelParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public ModelParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();
            this.state.ruleMemo = new Hashtable[68+1];
             
             
        }
        
    protected ITreeAdaptor adaptor = new CommonTreeAdaptor();

    public ITreeAdaptor TreeAdaptor
    {
        get { return this.adaptor; }
        set {
    	this.adaptor = value;
    	}
    }

    override public string[] TokenNames {
		get { return ModelParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "Model.g"; }
    }


        private  System.Collections.Generic.List<string> errors = new  System.Collections.Generic.List<string>();
        private System.Collections.Generic.List<string> frmlItems = new System.Collections.Generic.List<string>();
        public override void DisplayRecognitionError(string[] tokenNames,
                                            RecognitionException e) {
            string hdr = GetErrorHeader(e);
            string msg = GetErrorMessage(e, tokenNames);
            errors.Add(e.Line + "�" + e.CharPositionInLine + "�" + hdr + "�" + msg);
        }
        public  System.Collections.Generic.List<string> GetErrors() {
            return errors;
        }
        public System.Collections.Generic.List<string> GetFrmlItems() {
          return frmlItems;
        }    


    public class extraTokens_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "extraTokens"
    // Model.g:129:1: extraTokens : ( LOG | EXP | FRML | AFTER | AFTER2 | VAL | VARLIST );
    public ModelParser.extraTokens_return extraTokens() // throws RecognitionException [1]
    {   
        ModelParser.extraTokens_return retval = new ModelParser.extraTokens_return();
        retval.Start = input.LT(1);
        int extraTokens_StartIndex = input.Index();
        object root_0 = null;

        IToken set1 = null;

        object set1_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 1) ) 
    	    {
    	    	return retval; 
    	    }
            // Model.g:129:13: ( LOG | EXP | FRML | AFTER | AFTER2 | VAL | VARLIST )
            // Model.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set1 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= LOG && input.LA(1) <= VARLIST) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set1));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 1, extraTokens_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "extraTokens"

    public class expr_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "expr"
    // Model.g:143:1: expr : ( expr2 )+ EOF ;
    public ModelParser.expr_return expr() // throws RecognitionException [1]
    {   
        ModelParser.expr_return retval = new ModelParser.expr_return();
        retval.Start = input.LT(1);
        int expr_StartIndex = input.Index();
        object root_0 = null;

        IToken EOF3 = null;
        ModelParser.expr2_return expr22 = default(ModelParser.expr2_return);


        object EOF3_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 2) ) 
    	    {
    	    	return retval; 
    	    }
            // Model.g:143:6: ( ( expr2 )+ EOF )
            // Model.g:143:8: ( expr2 )+ EOF
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// Model.g:143:8: ( expr2 )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( ((LA1_0 >= FRML && LA1_0 <= VAL) || LA1_0 == Modelblock || (LA1_0 >= 90 && LA1_0 <= 91)) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // Model.g:143:9: expr2
            			    {
            			    	PushFollow(FOLLOW_expr2_in_expr450);
            			    	expr22 = expr2();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr22.Tree);

            			    }
            			    break;

            			default:
            			    if ( cnt1 >= 1 ) goto loop1;
            			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		            EarlyExitException eee1 =
            		                new EarlyExitException(1, input);
            		            throw eee1;
            	    }
            	    cnt1++;
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements

            	EOF3=(IToken)Match(input,EOF,FOLLOW_EOF_in_expr454); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{EOF3_tree = (object)adaptor.Create(EOF3);
            		adaptor.AddChild(root_0, EOF3_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 2, expr_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "expr"

    public class expr2_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "expr2"
    // Model.g:145:1: expr2 : ( frml | val | Modelblock -> ^( ASTMODELBLOCK Modelblock ) | AFTER frmlEnding -> ^( ASTAFTER ) | AFTER2 frmlEnding -> ^( ASTAFTER2 ) | frmlEnding ->);
    public ModelParser.expr2_return expr2() // throws RecognitionException [1]
    {   
        ModelParser.expr2_return retval = new ModelParser.expr2_return();
        retval.Start = input.LT(1);
        int expr2_StartIndex = input.Index();
        object root_0 = null;

        IToken Modelblock6 = null;
        IToken AFTER7 = null;
        IToken AFTER29 = null;
        ModelParser.frml_return frml4 = default(ModelParser.frml_return);

        ModelParser.val_return val5 = default(ModelParser.val_return);

        ModelParser.frmlEnding_return frmlEnding8 = default(ModelParser.frmlEnding_return);

        ModelParser.frmlEnding_return frmlEnding10 = default(ModelParser.frmlEnding_return);

        ModelParser.frmlEnding_return frmlEnding11 = default(ModelParser.frmlEnding_return);


        object Modelblock6_tree=null;
        object AFTER7_tree=null;
        object AFTER29_tree=null;
        RewriteRuleTokenStream stream_AFTER2 = new RewriteRuleTokenStream(adaptor,"token AFTER2");
        RewriteRuleTokenStream stream_AFTER = new RewriteRuleTokenStream(adaptor,"token AFTER");
        RewriteRuleTokenStream stream_Modelblock = new RewriteRuleTokenStream(adaptor,"token Modelblock");
        RewriteRuleSubtreeStream stream_frmlEnding = new RewriteRuleSubtreeStream(adaptor,"rule frmlEnding");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 3) ) 
    	    {
    	    	return retval; 
    	    }
            // Model.g:145:10: ( frml | val | Modelblock -> ^( ASTMODELBLOCK Modelblock ) | AFTER frmlEnding -> ^( ASTAFTER ) | AFTER2 frmlEnding -> ^( ASTAFTER2 ) | frmlEnding ->)
            int alt2 = 6;
            switch ( input.LA(1) ) 
            {
            case FRML:
            	{
                alt2 = 1;
                }
                break;
            case VAL:
            	{
                alt2 = 2;
                }
                break;
            case Modelblock:
            	{
                alt2 = 3;
                }
                break;
            case AFTER:
            	{
                alt2 = 4;
                }
                break;
            case AFTER2:
            	{
                alt2 = 5;
                }
                break;
            case 90:
            case 91:
            	{
                alt2 = 6;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d2s0 =
            	        new NoViableAltException("", 2, 0, input);

            	    throw nvae_d2s0;
            }

            switch (alt2) 
            {
                case 1 :
                    // Model.g:146:3: frml
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_frml_in_expr2474);
                    	frml4 = frml();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, frml4.Tree);

                    }
                    break;
                case 2 :
                    // Model.g:147:5: val
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_val_in_expr2480);
                    	val5 = val();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, val5.Tree);

                    }
                    break;
                case 3 :
                    // Model.g:148:5: Modelblock
                    {
                    	Modelblock6=(IToken)Match(input,Modelblock,FOLLOW_Modelblock_in_expr2486); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_Modelblock.Add(Modelblock6);



                    	// AST REWRITE
                    	// elements:          Modelblock
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 148:16: -> ^( ASTMODELBLOCK Modelblock )
                    	{
                    	    // Model.g:148:19: ^( ASTMODELBLOCK Modelblock )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ASTMODELBLOCK, "ASTMODELBLOCK"), root_1);

                    	    adaptor.AddChild(root_1, stream_Modelblock.NextNode());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 4 :
                    // Model.g:149:5: AFTER frmlEnding
                    {
                    	AFTER7=(IToken)Match(input,AFTER,FOLLOW_AFTER_in_expr2500); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_AFTER.Add(AFTER7);

                    	PushFollow(FOLLOW_frmlEnding_in_expr2502);
                    	frmlEnding8 = frmlEnding();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_frmlEnding.Add(frmlEnding8.Tree);


                    	// AST REWRITE
                    	// elements:          
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 149:22: -> ^( ASTAFTER )
                    	{
                    	    // Model.g:149:26: ^( ASTAFTER )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ASTAFTER, "ASTAFTER"), root_1);

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 5 :
                    // Model.g:150:5: AFTER2 frmlEnding
                    {
                    	AFTER29=(IToken)Match(input,AFTER2,FOLLOW_AFTER2_in_expr2515); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_AFTER2.Add(AFTER29);

                    	PushFollow(FOLLOW_frmlEnding_in_expr2517);
                    	frmlEnding10 = frmlEnding();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_frmlEnding.Add(frmlEnding10.Tree);


                    	// AST REWRITE
                    	// elements:          
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 150:23: -> ^( ASTAFTER2 )
                    	{
                    	    // Model.g:150:27: ^( ASTAFTER2 )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ASTAFTER2, "ASTAFTER2"), root_1);

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 6 :
                    // Model.g:151:5: frmlEnding
                    {
                    	PushFollow(FOLLOW_frmlEnding_in_expr2532);
                    	frmlEnding11 = frmlEnding();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_frmlEnding.Add(frmlEnding11.Tree);


                    	// AST REWRITE
                    	// elements:          
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 151:16: ->
                    	{
                    	    root_0 = null;
                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 3, expr2_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "expr2"

    public class frml_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "frml"
    // Model.g:154:1: frml : FRML code genrLeftSide '=' expression2 frmlEnding -> ^( ASTFRML code genrLeftSide expression2 ) ;
    public ModelParser.frml_return frml() // throws RecognitionException [1]
    {   
        ModelParser.frml_return retval = new ModelParser.frml_return();
        retval.Start = input.LT(1);
        int frml_StartIndex = input.Index();
        object root_0 = null;

        IToken FRML12 = null;
        IToken char_literal15 = null;
        ModelParser.code_return code13 = default(ModelParser.code_return);

        ModelParser.genrLeftSide_return genrLeftSide14 = default(ModelParser.genrLeftSide_return);

        ModelParser.expression2_return expression216 = default(ModelParser.expression2_return);

        ModelParser.frmlEnding_return frmlEnding17 = default(ModelParser.frmlEnding_return);


        object FRML12_tree=null;
        object char_literal15_tree=null;
        RewriteRuleTokenStream stream_FRML = new RewriteRuleTokenStream(adaptor,"token FRML");
        RewriteRuleTokenStream stream_85 = new RewriteRuleTokenStream(adaptor,"token 85");
        RewriteRuleSubtreeStream stream_frmlEnding = new RewriteRuleSubtreeStream(adaptor,"rule frmlEnding");
        RewriteRuleSubtreeStream stream_genrLeftSide = new RewriteRuleSubtreeStream(adaptor,"rule genrLeftSide");
        RewriteRuleSubtreeStream stream_expression2 = new RewriteRuleSubtreeStream(adaptor,"rule expression2");
        RewriteRuleSubtreeStream stream_code = new RewriteRuleSubtreeStream(adaptor,"rule code");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 4) ) 
    	    {
    	    	return retval; 
    	    }
            // Model.g:154:9: ( FRML code genrLeftSide '=' expression2 frmlEnding -> ^( ASTFRML code genrLeftSide expression2 ) )
            // Model.g:154:11: FRML code genrLeftSide '=' expression2 frmlEnding
            {
            	FRML12=(IToken)Match(input,FRML,FOLLOW_FRML_in_frml565); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_FRML.Add(FRML12);

            	PushFollow(FOLLOW_code_in_frml567);
            	code13 = code();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_code.Add(code13.Tree);
            	PushFollow(FOLLOW_genrLeftSide_in_frml569);
            	genrLeftSide14 = genrLeftSide();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_genrLeftSide.Add(genrLeftSide14.Tree);
            	char_literal15=(IToken)Match(input,85,FOLLOW_85_in_frml571); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_85.Add(char_literal15);

            	PushFollow(FOLLOW_expression2_in_frml573);
            	expression216 = expression2();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_expression2.Add(expression216.Tree);
            	PushFollow(FOLLOW_frmlEnding_in_frml575);
            	frmlEnding17 = frmlEnding();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_frmlEnding.Add(frmlEnding17.Tree);
            	if ( (state.backtracking==0) )
            	{
            	  frmlItems.Add(input.ToString((IToken)retval.Start,input.LT(-1)));
            	}


            	// AST REWRITE
            	// elements:          expression2, genrLeftSide, code
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 157:3: -> ^( ASTFRML code genrLeftSide expression2 )
            	{
            	    // Model.g:157:6: ^( ASTFRML code genrLeftSide expression2 )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ASTFRML, "ASTFRML"), root_1);

            	    adaptor.AddChild(root_1, stream_code.NextTree());
            	    adaptor.AddChild(root_1, stream_genrLeftSide.NextTree());
            	    adaptor.AddChild(root_1, stream_expression2.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 4, frml_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "frml"

    public class genrLeftSide_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "genrLeftSide"
    // Model.g:160:1: genrLeftSide : genrLeftSide2 -> ^( ASTLEFTSIDE genrLeftSide2 ) ;
    public ModelParser.genrLeftSide_return genrLeftSide() // throws RecognitionException [1]
    {   
        ModelParser.genrLeftSide_return retval = new ModelParser.genrLeftSide_return();
        retval.Start = input.LT(1);
        int genrLeftSide_StartIndex = input.Index();
        object root_0 = null;

        ModelParser.genrLeftSide2_return genrLeftSide218 = default(ModelParser.genrLeftSide2_return);


        RewriteRuleSubtreeStream stream_genrLeftSide2 = new RewriteRuleSubtreeStream(adaptor,"rule genrLeftSide2");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 5) ) 
    	    {
    	    	return retval; 
    	    }
            // Model.g:160:14: ( genrLeftSide2 -> ^( ASTLEFTSIDE genrLeftSide2 ) )
            // Model.g:160:16: genrLeftSide2
            {
            	PushFollow(FOLLOW_genrLeftSide2_in_genrLeftSide611);
            	genrLeftSide218 = genrLeftSide2();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_genrLeftSide2.Add(genrLeftSide218.Tree);


            	// AST REWRITE
            	// elements:          genrLeftSide2
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 160:30: -> ^( ASTLEFTSIDE genrLeftSide2 )
            	{
            	    // Model.g:160:33: ^( ASTLEFTSIDE genrLeftSide2 )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ASTLEFTSIDE, "ASTLEFTSIDE"), root_1);

            	    adaptor.AddChild(root_1, stream_genrLeftSide2.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 5, genrLeftSide_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "genrLeftSide"

    public class genrLeftSide2_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "genrLeftSide2"
    // Model.g:161:1: genrLeftSide2 : ( ident | simpleFunction ) ;
    public ModelParser.genrLeftSide2_return genrLeftSide2() // throws RecognitionException [1]
    {   
        ModelParser.genrLeftSide2_return retval = new ModelParser.genrLeftSide2_return();
        retval.Start = input.LT(1);
        int genrLeftSide2_StartIndex = input.Index();
        object root_0 = null;

        ModelParser.ident_return ident19 = default(ModelParser.ident_return);

        ModelParser.simpleFunction_return simpleFunction20 = default(ModelParser.simpleFunction_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 6) ) 
    	    {
    	    	return retval; 
    	    }
            // Model.g:161:15: ( ( ident | simpleFunction ) )
            // Model.g:161:17: ( ident | simpleFunction )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// Model.g:161:17: ( ident | simpleFunction )
            	int alt3 = 2;
            	int LA3_0 = input.LA(1);

            	if ( (LA3_0 == Ident) )
            	{
            	    int LA3_1 = input.LA(2);

            	    if ( (LA3_1 == 86) )
            	    {
            	        alt3 = 2;
            	    }
            	    else if ( (LA3_1 == 85) )
            	    {
            	        alt3 = 1;
            	    }
            	    else 
            	    {
            	        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        NoViableAltException nvae_d3s1 =
            	            new NoViableAltException("", 3, 1, input);

            	        throw nvae_d3s1;
            	    }
            	}
            	else if ( ((LA3_0 >= LOG && LA3_0 <= VARLIST)) )
            	{
            	    int LA3_2 = input.LA(2);

            	    if ( (LA3_2 == 86) )
            	    {
            	        alt3 = 2;
            	    }
            	    else if ( (LA3_2 == 85) )
            	    {
            	        alt3 = 1;
            	    }
            	    else 
            	    {
            	        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        NoViableAltException nvae_d3s2 =
            	            new NoViableAltException("", 3, 2, input);

            	        throw nvae_d3s2;
            	    }
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d3s0 =
            	        new NoViableAltException("", 3, 0, input);

            	    throw nvae_d3s0;
            	}
            	switch (alt3) 
            	{
            	    case 1 :
            	        // Model.g:161:18: ident
            	        {
            	        	PushFollow(FOLLOW_ident_in_genrLeftSide2627);
            	        	ident19 = ident();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ident19.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // Model.g:161:24: simpleFunction
            	        {
            	        	PushFollow(FOLLOW_simpleFunction_in_genrLeftSide2629);
            	        	simpleFunction20 = simpleFunction();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, simpleFunction20.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 6, genrLeftSide2_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "genrLeftSide2"

    public class code_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "code"
    // Model.g:162:1: code : ident -> ^( ASTFRMLCODE ident ) ;
    public ModelParser.code_return code() // throws RecognitionException [1]
    {   
        ModelParser.code_return retval = new ModelParser.code_return();
        retval.Start = input.LT(1);
        int code_StartIndex = input.Index();
        object root_0 = null;

        ModelParser.ident_return ident21 = default(ModelParser.ident_return);


        RewriteRuleSubtreeStream stream_ident = new RewriteRuleSubtreeStream(adaptor,"rule ident");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 7) ) 
    	    {
    	    	return retval; 
    	    }
            // Model.g:162:6: ( ident -> ^( ASTFRMLCODE ident ) )
            // Model.g:162:8: ident
            {
            	PushFollow(FOLLOW_ident_in_code637);
            	ident21 = ident();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_ident.Add(ident21.Tree);


            	// AST REWRITE
            	// elements:          ident
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 162:14: -> ^( ASTFRMLCODE ident )
            	{
            	    // Model.g:162:17: ^( ASTFRMLCODE ident )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ASTFRMLCODE, "ASTFRMLCODE"), root_1);

            	    adaptor.AddChild(root_1, stream_ident.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 7, code_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "code"

    public class expression2_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "expression2"
    // Model.g:163:1: expression2 : expression -> ^( ASTEXPRESSION expression ) ;
    public ModelParser.expression2_return expression2() // throws RecognitionException [1]
    {   
        ModelParser.expression2_return retval = new ModelParser.expression2_return();
        retval.Start = input.LT(1);
        int expression2_StartIndex = input.Index();
        object root_0 = null;

        ModelParser.expression_return expression22 = default(ModelParser.expression_return);


        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 8) ) 
    	    {
    	    	return retval; 
    	    }
            // Model.g:163:13: ( expression -> ^( ASTEXPRESSION expression ) )
            // Model.g:163:15: expression
            {
            	PushFollow(FOLLOW_expression_in_expression2652);
            	expression22 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_expression.Add(expression22.Tree);


            	// AST REWRITE
            	// elements:          expression
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 163:26: -> ^( ASTEXPRESSION expression )
            	{
            	    // Model.g:163:29: ^( ASTEXPRESSION expression )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ASTEXPRESSION, "ASTEXPRESSION"), root_1);

            	    adaptor.AddChild(root_1, stream_expression.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 8, expression2_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "expression2"

    public class number_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "number"
    // Model.g:165:1: number : ( Double | Integer ) ;
    public ModelParser.number_return number() // throws RecognitionException [1]
    {   
        ModelParser.number_return retval = new ModelParser.number_return();
        retval.Start = input.LT(1);
        int number_StartIndex = input.Index();
        object root_0 = null;

        IToken set23 = null;

        object set23_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 9) ) 
    	    {
    	    	return retval; 
    	    }
            // Model.g:165:7: ( ( Double | Integer ) )
            // Model.g:165:9: ( Double | Integer )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set23 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= Double && input.LA(1) <= Integer) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set23));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 9, number_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "number"

    public class val_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "val"
    // Model.g:167:1: val : VAL Ident '=' ( MINUS )? number -> ^( ASTVAL Ident number ( MINUS )? ) ;
    public ModelParser.val_return val() // throws RecognitionException [1]
    {   
        ModelParser.val_return retval = new ModelParser.val_return();
        retval.Start = input.LT(1);
        int val_StartIndex = input.Index();
        object root_0 = null;

        IToken VAL24 = null;
        IToken Ident25 = null;
        IToken char_literal26 = null;
        IToken MINUS27 = null;
        ModelParser.number_return number28 = default(ModelParser.number_return);


        object VAL24_tree=null;
        object Ident25_tree=null;
        object char_literal26_tree=null;
        object MINUS27_tree=null;
        RewriteRuleTokenStream stream_VAL = new RewriteRuleTokenStream(adaptor,"token VAL");
        RewriteRuleTokenStream stream_Ident = new RewriteRuleTokenStream(adaptor,"token Ident");
        RewriteRuleTokenStream stream_MINUS = new RewriteRuleTokenStream(adaptor,"token MINUS");
        RewriteRuleTokenStream stream_85 = new RewriteRuleTokenStream(adaptor,"token 85");
        RewriteRuleSubtreeStream stream_number = new RewriteRuleSubtreeStream(adaptor,"rule number");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 10) ) 
    	    {
    	    	return retval; 
    	    }
            // Model.g:167:5: ( VAL Ident '=' ( MINUS )? number -> ^( ASTVAL Ident number ( MINUS )? ) )
            // Model.g:167:7: VAL Ident '=' ( MINUS )? number
            {
            	VAL24=(IToken)Match(input,VAL,FOLLOW_VAL_in_val679); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_VAL.Add(VAL24);

            	Ident25=(IToken)Match(input,Ident,FOLLOW_Ident_in_val681); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_Ident.Add(Ident25);

            	char_literal26=(IToken)Match(input,85,FOLLOW_85_in_val683); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_85.Add(char_literal26);

            	// Model.g:167:21: ( MINUS )?
            	int alt4 = 2;
            	int LA4_0 = input.LA(1);

            	if ( (LA4_0 == MINUS) )
            	{
            	    alt4 = 1;
            	}
            	switch (alt4) 
            	{
            	    case 1 :
            	        // Model.g:0:0: MINUS
            	        {
            	        	MINUS27=(IToken)Match(input,MINUS,FOLLOW_MINUS_in_val685); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_MINUS.Add(MINUS27);


            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_number_in_val688);
            	number28 = number();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_number.Add(number28.Tree);


            	// AST REWRITE
            	// elements:          MINUS, number, Ident
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 167:35: -> ^( ASTVAL Ident number ( MINUS )? )
            	{
            	    // Model.g:167:38: ^( ASTVAL Ident number ( MINUS )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ASTVAL, "ASTVAL"), root_1);

            	    adaptor.AddChild(root_1, stream_Ident.NextNode());
            	    adaptor.AddChild(root_1, stream_number.NextTree());
            	    // Model.g:167:60: ( MINUS )?
            	    if ( stream_MINUS.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_MINUS.NextNode());

            	    }
            	    stream_MINUS.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 10, val_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "val"

    public class simpleFunction_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "simpleFunction"
    // Model.g:173:1: simpleFunction : ident '(' ident ')' -> ^( ASTSIMPLEFUNCTION ident ident ) ;
    public ModelParser.simpleFunction_return simpleFunction() // throws RecognitionException [1]
    {   
        ModelParser.simpleFunction_return retval = new ModelParser.simpleFunction_return();
        retval.Start = input.LT(1);
        int simpleFunction_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal30 = null;
        IToken char_literal32 = null;
        ModelParser.ident_return ident29 = default(ModelParser.ident_return);

        ModelParser.ident_return ident31 = default(ModelParser.ident_return);


        object char_literal30_tree=null;
        object char_literal32_tree=null;
        RewriteRuleTokenStream stream_RP = new RewriteRuleTokenStream(adaptor,"token RP");
        RewriteRuleTokenStream stream_86 = new RewriteRuleTokenStream(adaptor,"token 86");
        RewriteRuleSubtreeStream stream_ident = new RewriteRuleSubtreeStream(adaptor,"rule ident");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 11) ) 
    	    {
    	    	return retval; 
    	    }
            // Model.g:174:2: ( ident '(' ident ')' -> ^( ASTSIMPLEFUNCTION ident ident ) )
            // Model.g:174:4: ident '(' ident ')'
            {
            	PushFollow(FOLLOW_ident_in_simpleFunction715);
            	ident29 = ident();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_ident.Add(ident29.Tree);
            	char_literal30=(IToken)Match(input,86,FOLLOW_86_in_simpleFunction717); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_86.Add(char_literal30);

            	PushFollow(FOLLOW_ident_in_simpleFunction719);
            	ident31 = ident();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_ident.Add(ident31.Tree);
            	char_literal32=(IToken)Match(input,RP,FOLLOW_RP_in_simpleFunction721); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_RP.Add(char_literal32);



            	// AST REWRITE
            	// elements:          ident, ident
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 174:24: -> ^( ASTSIMPLEFUNCTION ident ident )
            	{
            	    // Model.g:174:27: ^( ASTSIMPLEFUNCTION ident ident )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ASTSIMPLEFUNCTION, "ASTSIMPLEFUNCTION"), root_1);

            	    adaptor.AddChild(root_1, stream_ident.NextTree());
            	    adaptor.AddChild(root_1, stream_ident.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 11, simpleFunction_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "simpleFunction"

    public class function_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "function"
    // Model.g:177:1: function : ident '(' ( expression ( ',' expression )* )? ')' -> ^( ASTFUNCTION ident expression ( expression )* ) ;
    public ModelParser.function_return function() // throws RecognitionException [1]
    {   
        ModelParser.function_return retval = new ModelParser.function_return();
        retval.Start = input.LT(1);
        int function_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal34 = null;
        IToken char_literal36 = null;
        IToken char_literal38 = null;
        ModelParser.ident_return ident33 = default(ModelParser.ident_return);

        ModelParser.expression_return expression35 = default(ModelParser.expression_return);

        ModelParser.expression_return expression37 = default(ModelParser.expression_return);


        object char_literal34_tree=null;
        object char_literal36_tree=null;
        object char_literal38_tree=null;
        RewriteRuleTokenStream stream_RP = new RewriteRuleTokenStream(adaptor,"token RP");
        RewriteRuleTokenStream stream_86 = new RewriteRuleTokenStream(adaptor,"token 86");
        RewriteRuleTokenStream stream_87 = new RewriteRuleTokenStream(adaptor,"token 87");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_ident = new RewriteRuleSubtreeStream(adaptor,"rule ident");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 12) ) 
    	    {
    	    	return retval; 
    	    }
            // Model.g:177:10: ( ident '(' ( expression ( ',' expression )* )? ')' -> ^( ASTFUNCTION ident expression ( expression )* ) )
            // Model.g:177:12: ident '(' ( expression ( ',' expression )* )? ')'
            {
            	PushFollow(FOLLOW_ident_in_function742);
            	ident33 = ident();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_ident.Add(ident33.Tree);
            	char_literal34=(IToken)Match(input,86,FOLLOW_86_in_function744); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_86.Add(char_literal34);

            	// Model.g:177:22: ( expression ( ',' expression )* )?
            	int alt6 = 2;
            	alt6 = dfa6.Predict(input);
            	switch (alt6) 
            	{
            	    case 1 :
            	        // Model.g:177:24: expression ( ',' expression )*
            	        {
            	        	PushFollow(FOLLOW_expression_in_function748);
            	        	expression35 = expression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_expression.Add(expression35.Tree);
            	        	// Model.g:177:35: ( ',' expression )*
            	        	do 
            	        	{
            	        	    int alt5 = 2;
            	        	    int LA5_0 = input.LA(1);

            	        	    if ( (LA5_0 == 87) )
            	        	    {
            	        	        alt5 = 1;
            	        	    }


            	        	    switch (alt5) 
            	        		{
            	        			case 1 :
            	        			    // Model.g:177:36: ',' expression
            	        			    {
            	        			    	char_literal36=(IToken)Match(input,87,FOLLOW_87_in_function751); if (state.failed) return retval; 
            	        			    	if ( (state.backtracking==0) ) stream_87.Add(char_literal36);

            	        			    	PushFollow(FOLLOW_expression_in_function753);
            	        			    	expression37 = expression();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( (state.backtracking==0) ) stream_expression.Add(expression37.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop5;
            	        	    }
            	        	} while (true);

            	        	loop5:
            	        		;	// Stops C# compiler whining that label 'loop5' has no statements


            	        }
            	        break;

            	}

            	char_literal38=(IToken)Match(input,RP,FOLLOW_RP_in_function760); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_RP.Add(char_literal38);



            	// AST REWRITE
            	// elements:          expression, expression, ident
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 177:60: -> ^( ASTFUNCTION ident expression ( expression )* )
            	{
            	    // Model.g:177:63: ^( ASTFUNCTION ident expression ( expression )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ASTFUNCTION, "ASTFUNCTION"), root_1);

            	    adaptor.AddChild(root_1, stream_ident.NextTree());
            	    adaptor.AddChild(root_1, stream_expression.NextTree());
            	    // Model.g:177:94: ( expression )*
            	    while ( stream_expression.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_expression.NextTree());

            	    }
            	    stream_expression.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 12, function_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "function"

    public class functionLogExp_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "functionLogExp"
    // Model.g:178:1: functionLogExp : logExp '(' ( expression ( ',' expression )* )? ')' -> ^( ASTFUNCTION logExp expression ( expression )* ) ;
    public ModelParser.functionLogExp_return functionLogExp() // throws RecognitionException [1]
    {   
        ModelParser.functionLogExp_return retval = new ModelParser.functionLogExp_return();
        retval.Start = input.LT(1);
        int functionLogExp_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal40 = null;
        IToken char_literal42 = null;
        IToken char_literal44 = null;
        ModelParser.logExp_return logExp39 = default(ModelParser.logExp_return);

        ModelParser.expression_return expression41 = default(ModelParser.expression_return);

        ModelParser.expression_return expression43 = default(ModelParser.expression_return);


        object char_literal40_tree=null;
        object char_literal42_tree=null;
        object char_literal44_tree=null;
        RewriteRuleTokenStream stream_RP = new RewriteRuleTokenStream(adaptor,"token RP");
        RewriteRuleTokenStream stream_86 = new RewriteRuleTokenStream(adaptor,"token 86");
        RewriteRuleTokenStream stream_87 = new RewriteRuleTokenStream(adaptor,"token 87");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_logExp = new RewriteRuleSubtreeStream(adaptor,"rule logExp");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 13) ) 
    	    {
    	    	return retval; 
    	    }
            // Model.g:178:15: ( logExp '(' ( expression ( ',' expression )* )? ')' -> ^( ASTFUNCTION logExp expression ( expression )* ) )
            // Model.g:178:17: logExp '(' ( expression ( ',' expression )* )? ')'
            {
            	PushFollow(FOLLOW_logExp_in_functionLogExp780);
            	logExp39 = logExp();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_logExp.Add(logExp39.Tree);
            	char_literal40=(IToken)Match(input,86,FOLLOW_86_in_functionLogExp782); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_86.Add(char_literal40);

            	// Model.g:178:28: ( expression ( ',' expression )* )?
            	int alt8 = 2;
            	alt8 = dfa8.Predict(input);
            	switch (alt8) 
            	{
            	    case 1 :
            	        // Model.g:178:30: expression ( ',' expression )*
            	        {
            	        	PushFollow(FOLLOW_expression_in_functionLogExp786);
            	        	expression41 = expression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_expression.Add(expression41.Tree);
            	        	// Model.g:178:41: ( ',' expression )*
            	        	do 
            	        	{
            	        	    int alt7 = 2;
            	        	    int LA7_0 = input.LA(1);

            	        	    if ( (LA7_0 == 87) )
            	        	    {
            	        	        alt7 = 1;
            	        	    }


            	        	    switch (alt7) 
            	        		{
            	        			case 1 :
            	        			    // Model.g:178:42: ',' expression
            	        			    {
            	        			    	char_literal42=(IToken)Match(input,87,FOLLOW_87_in_functionLogExp789); if (state.failed) return retval; 
            	        			    	if ( (state.backtracking==0) ) stream_87.Add(char_literal42);

            	        			    	PushFollow(FOLLOW_expression_in_functionLogExp791);
            	        			    	expression43 = expression();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( (state.backtracking==0) ) stream_expression.Add(expression43.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop7;
            	        	    }
            	        	} while (true);

            	        	loop7:
            	        		;	// Stops C# compiler whining that label 'loop7' has no statements


            	        }
            	        break;

            	}

            	char_literal44=(IToken)Match(input,RP,FOLLOW_RP_in_functionLogExp798); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_RP.Add(char_literal44);



            	// AST REWRITE
            	// elements:          logExp, expression, expression
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 178:66: -> ^( ASTFUNCTION logExp expression ( expression )* )
            	{
            	    // Model.g:178:69: ^( ASTFUNCTION logExp expression ( expression )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ASTFUNCTION, "ASTFUNCTION"), root_1);

            	    adaptor.AddChild(root_1, stream_logExp.NextTree());
            	    adaptor.AddChild(root_1, stream_expression.NextTree());
            	    // Model.g:178:101: ( expression )*
            	    while ( stream_expression.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_expression.NextTree());

            	    }
            	    stream_expression.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 13, functionLogExp_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "functionLogExp"

    public class lagFunction_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "lagFunction"
    // Model.g:180:1: lagFunction : '(' expression ')' '(' numberPlusMinus ')' -> ^( ASTLAGFUNCTION expression numberPlusMinus ) ;
    public ModelParser.lagFunction_return lagFunction() // throws RecognitionException [1]
    {   
        ModelParser.lagFunction_return retval = new ModelParser.lagFunction_return();
        retval.Start = input.LT(1);
        int lagFunction_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal45 = null;
        IToken char_literal47 = null;
        IToken char_literal48 = null;
        IToken char_literal50 = null;
        ModelParser.expression_return expression46 = default(ModelParser.expression_return);

        ModelParser.numberPlusMinus_return numberPlusMinus49 = default(ModelParser.numberPlusMinus_return);


        object char_literal45_tree=null;
        object char_literal47_tree=null;
        object char_literal48_tree=null;
        object char_literal50_tree=null;
        RewriteRuleTokenStream stream_RP = new RewriteRuleTokenStream(adaptor,"token RP");
        RewriteRuleTokenStream stream_86 = new RewriteRuleTokenStream(adaptor,"token 86");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_numberPlusMinus = new RewriteRuleSubtreeStream(adaptor,"rule numberPlusMinus");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 14) ) 
    	    {
    	    	return retval; 
    	    }
            // Model.g:180:13: ( '(' expression ')' '(' numberPlusMinus ')' -> ^( ASTLAGFUNCTION expression numberPlusMinus ) )
            // Model.g:180:15: '(' expression ')' '(' numberPlusMinus ')'
            {
            	char_literal45=(IToken)Match(input,86,FOLLOW_86_in_lagFunction823); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_86.Add(char_literal45);

            	PushFollow(FOLLOW_expression_in_lagFunction825);
            	expression46 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_expression.Add(expression46.Tree);
            	char_literal47=(IToken)Match(input,RP,FOLLOW_RP_in_lagFunction827); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_RP.Add(char_literal47);

            	char_literal48=(IToken)Match(input,86,FOLLOW_86_in_lagFunction829); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_86.Add(char_literal48);

            	PushFollow(FOLLOW_numberPlusMinus_in_lagFunction831);
            	numberPlusMinus49 = numberPlusMinus();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_numberPlusMinus.Add(numberPlusMinus49.Tree);
            	char_literal50=(IToken)Match(input,RP,FOLLOW_RP_in_lagFunction833); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_RP.Add(char_literal50);



            	// AST REWRITE
            	// elements:          numberPlusMinus, expression
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 180:58: -> ^( ASTLAGFUNCTION expression numberPlusMinus )
            	{
            	    // Model.g:180:61: ^( ASTLAGFUNCTION expression numberPlusMinus )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ASTLAGFUNCTION, "ASTLAGFUNCTION"), root_1);

            	    adaptor.AddChild(root_1, stream_expression.NextTree());
            	    adaptor.AddChild(root_1, stream_numberPlusMinus.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 14, lagFunction_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "lagFunction"

    public class expression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "expression"
    // Model.g:182:1: expression : additiveExpression ;
    public ModelParser.expression_return expression() // throws RecognitionException [1]
    {   
        ModelParser.expression_return retval = new ModelParser.expression_return();
        retval.Start = input.LT(1);
        int expression_StartIndex = input.Index();
        object root_0 = null;

        ModelParser.additiveExpression_return additiveExpression51 = default(ModelParser.additiveExpression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 15) ) 
    	    {
    	    	return retval; 
    	    }
            // Model.g:182:12: ( additiveExpression )
            // Model.g:184:4: additiveExpression
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_additiveExpression_in_expression859);
            	additiveExpression51 = additiveExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, additiveExpression51.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 15, expression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "expression"

    public class additiveExpression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "additiveExpression"
    // Model.g:186:1: additiveExpression : multiplicativeExpression ( ( PLUS | MINUS ) multiplicativeExpression )* ;
    public ModelParser.additiveExpression_return additiveExpression() // throws RecognitionException [1]
    {   
        ModelParser.additiveExpression_return retval = new ModelParser.additiveExpression_return();
        retval.Start = input.LT(1);
        int additiveExpression_StartIndex = input.Index();
        object root_0 = null;

        IToken set53 = null;
        ModelParser.multiplicativeExpression_return multiplicativeExpression52 = default(ModelParser.multiplicativeExpression_return);

        ModelParser.multiplicativeExpression_return multiplicativeExpression54 = default(ModelParser.multiplicativeExpression_return);


        object set53_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 16) ) 
    	    {
    	    	return retval; 
    	    }
            // Model.g:186:21: ( multiplicativeExpression ( ( PLUS | MINUS ) multiplicativeExpression )* )
            // Model.g:186:23: multiplicativeExpression ( ( PLUS | MINUS ) multiplicativeExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression868);
            	multiplicativeExpression52 = multiplicativeExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, multiplicativeExpression52.Tree);
            	// Model.g:186:48: ( ( PLUS | MINUS ) multiplicativeExpression )*
            	do 
            	{
            	    int alt9 = 2;
            	    int LA9_0 = input.LA(1);

            	    if ( ((LA9_0 >= PLUS && LA9_0 <= MINUS)) )
            	    {
            	        alt9 = 1;
            	    }


            	    switch (alt9) 
            		{
            			case 1 :
            			    // Model.g:186:50: ( PLUS | MINUS ) multiplicativeExpression
            			    {
            			    	set53=(IToken)input.LT(1);
            			    	set53 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= PLUS && input.LA(1) <= MINUS) ) 
            			    	{
            			    	    input.Consume();
            			    	    if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set53), root_0);
            			    	    state.errorRecovery = false;state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression879);
            			    	multiplicativeExpression54 = multiplicativeExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, multiplicativeExpression54.Tree);

            			    }
            			    break;

            			default:
            			    goto loop9;
            	    }
            	} while (true);

            	loop9:
            		;	// Stops C# compiler whining that label 'loop9' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 16, additiveExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "additiveExpression"

    public class multiplicativeExpression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "multiplicativeExpression"
    // Model.g:188:1: multiplicativeExpression : powerExpression ( ( MULT | DIV | MOD ) powerExpression )* ;
    public ModelParser.multiplicativeExpression_return multiplicativeExpression() // throws RecognitionException [1]
    {   
        ModelParser.multiplicativeExpression_return retval = new ModelParser.multiplicativeExpression_return();
        retval.Start = input.LT(1);
        int multiplicativeExpression_StartIndex = input.Index();
        object root_0 = null;

        IToken set56 = null;
        ModelParser.powerExpression_return powerExpression55 = default(ModelParser.powerExpression_return);

        ModelParser.powerExpression_return powerExpression57 = default(ModelParser.powerExpression_return);


        object set56_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 17) ) 
    	    {
    	    	return retval; 
    	    }
            // Model.g:188:28: ( powerExpression ( ( MULT | DIV | MOD ) powerExpression )* )
            // Model.g:188:30: powerExpression ( ( MULT | DIV | MOD ) powerExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_powerExpression_in_multiplicativeExpression892);
            	powerExpression55 = powerExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, powerExpression55.Tree);
            	// Model.g:188:46: ( ( MULT | DIV | MOD ) powerExpression )*
            	do 
            	{
            	    int alt10 = 2;
            	    int LA10_0 = input.LA(1);

            	    if ( ((LA10_0 >= MULT && LA10_0 <= DIV) || LA10_0 == MOD) )
            	    {
            	        alt10 = 1;
            	    }


            	    switch (alt10) 
            		{
            			case 1 :
            			    // Model.g:188:48: ( MULT | DIV | MOD ) powerExpression
            			    {
            			    	set56=(IToken)input.LT(1);
            			    	set56 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= MULT && input.LA(1) <= DIV) || input.LA(1) == MOD ) 
            			    	{
            			    	    input.Consume();
            			    	    if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set56), root_0);
            			    	    state.errorRecovery = false;state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_powerExpression_in_multiplicativeExpression905);
            			    	powerExpression57 = powerExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, powerExpression57.Tree);

            			    }
            			    break;

            			default:
            			    goto loop10;
            	    }
            	} while (true);

            	loop10:
            		;	// Stops C# compiler whining that label 'loop10' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 17, multiplicativeExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "multiplicativeExpression"

    public class powerExpression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "powerExpression"
    // Model.g:190:1: powerExpression : unaryExpression ( pow unaryExpression )* ;
    public ModelParser.powerExpression_return powerExpression() // throws RecognitionException [1]
    {   
        ModelParser.powerExpression_return retval = new ModelParser.powerExpression_return();
        retval.Start = input.LT(1);
        int powerExpression_StartIndex = input.Index();
        object root_0 = null;

        ModelParser.unaryExpression_return unaryExpression58 = default(ModelParser.unaryExpression_return);

        ModelParser.pow_return pow59 = default(ModelParser.pow_return);

        ModelParser.unaryExpression_return unaryExpression60 = default(ModelParser.unaryExpression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 18) ) 
    	    {
    	    	return retval; 
    	    }
            // Model.g:190:19: ( unaryExpression ( pow unaryExpression )* )
            // Model.g:190:21: unaryExpression ( pow unaryExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_unaryExpression_in_powerExpression918);
            	unaryExpression58 = unaryExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression58.Tree);
            	// Model.g:190:37: ( pow unaryExpression )*
            	do 
            	{
            	    int alt11 = 2;
            	    int LA11_0 = input.LA(1);

            	    if ( ((LA11_0 >= STARS && LA11_0 <= HAT)) )
            	    {
            	        alt11 = 1;
            	    }


            	    switch (alt11) 
            		{
            			case 1 :
            			    // Model.g:190:39: pow unaryExpression
            			    {
            			    	PushFollow(FOLLOW_pow_in_powerExpression922);
            			    	pow59 = pow();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(pow59.Tree, root_0);
            			    	PushFollow(FOLLOW_unaryExpression_in_powerExpression925);
            			    	unaryExpression60 = unaryExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression60.Tree);

            			    }
            			    break;

            			default:
            			    goto loop11;
            	    }
            	} while (true);

            	loop11:
            		;	// Stops C# compiler whining that label 'loop11' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 18, powerExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "powerExpression"

    public class unaryExpression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "unaryExpression"
    // Model.g:192:1: unaryExpression : ( primaryExpression | MINUS primaryExpression -> ^( NEGATE primaryExpression ) );
    public ModelParser.unaryExpression_return unaryExpression() // throws RecognitionException [1]
    {   
        ModelParser.unaryExpression_return retval = new ModelParser.unaryExpression_return();
        retval.Start = input.LT(1);
        int unaryExpression_StartIndex = input.Index();
        object root_0 = null;

        IToken MINUS62 = null;
        ModelParser.primaryExpression_return primaryExpression61 = default(ModelParser.primaryExpression_return);

        ModelParser.primaryExpression_return primaryExpression63 = default(ModelParser.primaryExpression_return);


        object MINUS62_tree=null;
        RewriteRuleTokenStream stream_MINUS = new RewriteRuleTokenStream(adaptor,"token MINUS");
        RewriteRuleSubtreeStream stream_primaryExpression = new RewriteRuleSubtreeStream(adaptor,"rule primaryExpression");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 19) ) 
    	    {
    	    	return retval; 
    	    }
            // Model.g:193:4: ( primaryExpression | MINUS primaryExpression -> ^( NEGATE primaryExpression ) )
            int alt12 = 2;
            int LA12_0 = input.LA(1);

            if ( ((LA12_0 >= LOG && LA12_0 <= VARLIST) || (LA12_0 >= Double && LA12_0 <= Ident) || LA12_0 == AssignVar || LA12_0 == 86) )
            {
                alt12 = 1;
            }
            else if ( (LA12_0 == MINUS) )
            {
                alt12 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d12s0 =
                    new NoViableAltException("", 12, 0, input);

                throw nvae_d12s0;
            }
            switch (alt12) 
            {
                case 1 :
                    // Model.g:193:6: primaryExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_primaryExpression_in_unaryExpression940);
                    	primaryExpression61 = primaryExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, primaryExpression61.Tree);

                    }
                    break;
                case 2 :
                    // Model.g:194:10: MINUS primaryExpression
                    {
                    	MINUS62=(IToken)Match(input,MINUS,FOLLOW_MINUS_in_unaryExpression951); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_MINUS.Add(MINUS62);

                    	PushFollow(FOLLOW_primaryExpression_in_unaryExpression953);
                    	primaryExpression63 = primaryExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_primaryExpression.Add(primaryExpression63.Tree);


                    	// AST REWRITE
                    	// elements:          primaryExpression
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 194:34: -> ^( NEGATE primaryExpression )
                    	{
                    	    // Model.g:194:37: ^( NEGATE primaryExpression )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(NEGATE, "NEGATE"), root_1);

                    	    adaptor.AddChild(root_1, stream_primaryExpression.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 19, unaryExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "unaryExpression"

    public class primaryExpression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "primaryExpression"
    // Model.g:196:1: primaryExpression : ( '(' expression ')' | value );
    public ModelParser.primaryExpression_return primaryExpression() // throws RecognitionException [1]
    {   
        ModelParser.primaryExpression_return retval = new ModelParser.primaryExpression_return();
        retval.Start = input.LT(1);
        int primaryExpression_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal64 = null;
        IToken char_literal66 = null;
        ModelParser.expression_return expression65 = default(ModelParser.expression_return);

        ModelParser.value_return value67 = default(ModelParser.value_return);


        object char_literal64_tree=null;
        object char_literal66_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 20) ) 
    	    {
    	    	return retval; 
    	    }
            // Model.g:197:4: ( '(' expression ')' | value )
            int alt13 = 2;
            int LA13_0 = input.LA(1);

            if ( (LA13_0 == 86) )
            {
                alt13 = 1;
            }
            else if ( ((LA13_0 >= LOG && LA13_0 <= VARLIST) || (LA13_0 >= Double && LA13_0 <= Ident) || LA13_0 == AssignVar) )
            {
                alt13 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d13s0 =
                    new NoViableAltException("", 13, 0, input);

                throw nvae_d13s0;
            }
            switch (alt13) 
            {
                case 1 :
                    // Model.g:197:6: '(' expression ')'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal64=(IToken)Match(input,86,FOLLOW_86_in_primaryExpression980); if (state.failed) return retval;
                    	PushFollow(FOLLOW_expression_in_primaryExpression983);
                    	expression65 = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression65.Tree);
                    	char_literal66=(IToken)Match(input,RP,FOLLOW_RP_in_primaryExpression985); if (state.failed) return retval;

                    }
                    break;
                case 2 :
                    // Model.g:198:6: value
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_value_in_primaryExpression993);
                    	value67 = value();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value67.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 20, primaryExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "primaryExpression"

    public class value_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "value"
    // Model.g:200:1: value : ( Integer -> ^( ASTINTEGER Integer ) | Double -> ^( ASTDOUBLE Double ) | functionLogExp | variableWithLagOrLead | function | assignVar );
    public ModelParser.value_return value() // throws RecognitionException [1]
    {   
        ModelParser.value_return retval = new ModelParser.value_return();
        retval.Start = input.LT(1);
        int value_StartIndex = input.Index();
        object root_0 = null;

        IToken Integer68 = null;
        IToken Double69 = null;
        ModelParser.functionLogExp_return functionLogExp70 = default(ModelParser.functionLogExp_return);

        ModelParser.variableWithLagOrLead_return variableWithLagOrLead71 = default(ModelParser.variableWithLagOrLead_return);

        ModelParser.function_return function72 = default(ModelParser.function_return);

        ModelParser.assignVar_return assignVar73 = default(ModelParser.assignVar_return);


        object Integer68_tree=null;
        object Double69_tree=null;
        RewriteRuleTokenStream stream_Double = new RewriteRuleTokenStream(adaptor,"token Double");
        RewriteRuleTokenStream stream_Integer = new RewriteRuleTokenStream(adaptor,"token Integer");

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 21) ) 
    	    {
    	    	return retval; 
    	    }
            // Model.g:201:2: ( Integer -> ^( ASTINTEGER Integer ) | Double -> ^( ASTDOUBLE Double ) | functionLogExp | variableWithLagOrLead | function | assignVar )
            int alt14 = 6;
            alt14 = dfa14.Predict(input);
            switch (alt14) 
            {
                case 1 :
                    // Model.g:201:5: Integer
                    {
                    	Integer68=(IToken)Match(input,Integer,FOLLOW_Integer_in_value1007); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_Integer.Add(Integer68);



                    	// AST REWRITE
                    	// elements:          Integer
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 201:15: -> ^( ASTINTEGER Integer )
                    	{
                    	    // Model.g:201:18: ^( ASTINTEGER Integer )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ASTINTEGER, "ASTINTEGER"), root_1);

                    	    adaptor.AddChild(root_1, stream_Integer.NextNode());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // Model.g:202:4: Double
                    {
                    	Double69=(IToken)Match(input,Double,FOLLOW_Double_in_value1022); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_Double.Add(Double69);



                    	// AST REWRITE
                    	// elements:          Double
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 202:15: -> ^( ASTDOUBLE Double )
                    	{
                    	    // Model.g:202:18: ^( ASTDOUBLE Double )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ASTDOUBLE, "ASTDOUBLE"), root_1);

                    	    adaptor.AddChild(root_1, stream_Double.NextNode());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 3 :
                    // Model.g:203:4: functionLogExp
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_functionLogExp_in_value1039);
                    	functionLogExp70 = functionLogExp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, functionLogExp70.Tree);

                    }
                    break;
                case 4 :
                    // Model.g:204:4: variableWithLagOrLead
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_variableWithLagOrLead_in_value1063);
                    	variableWithLagOrLead71 = variableWithLagOrLead();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variableWithLagOrLead71.Tree);

                    }
                    break;
                case 5 :
                    // Model.g:205:4: function
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_function_in_value1075);
                    	function72 = function();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, function72.Tree);

                    }
                    break;
                case 6 :
                    // Model.g:206:6: assignVar
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_assignVar_in_value1083);
                    	assignVar73 = assignVar();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignVar73.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 21, value_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "value"

    public class assignVar_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "assignVar"
    // Model.g:209:1: assignVar : AssignVar -> ^( ASTASSIGNVAR AssignVar ) ;
    public ModelParser.assignVar_return assignVar() // throws RecognitionException [1]
    {   
        ModelParser.assignVar_return retval = new ModelParser.assignVar_return();
        retval.Start = input.LT(1);
        int assignVar_StartIndex = input.Index();
        object root_0 = null;

        IToken AssignVar74 = null;

        object AssignVar74_tree=null;
        RewriteRuleTokenStream stream_AssignVar = new RewriteRuleTokenStream(adaptor,"token AssignVar");

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 22) ) 
    	    {
    	    	return retval; 
    	    }
            // Model.g:209:11: ( AssignVar -> ^( ASTASSIGNVAR AssignVar ) )
            // Model.g:209:13: AssignVar
            {
            	AssignVar74=(IToken)Match(input,AssignVar,FOLLOW_AssignVar_in_assignVar1094); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_AssignVar.Add(AssignVar74);



            	// AST REWRITE
            	// elements:          AssignVar
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 209:23: -> ^( ASTASSIGNVAR AssignVar )
            	{
            	    // Model.g:209:26: ^( ASTASSIGNVAR AssignVar )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ASTASSIGNVAR, "ASTASSIGNVAR"), root_1);

            	    adaptor.AddChild(root_1, stream_AssignVar.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 22, assignVar_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "assignVar"

    public class variableWithLagOrLead_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "variableWithLagOrLead"
    // Model.g:211:1: variableWithLagOrLead : ( ident -> ^( ASTVARIABLE ident FALSE ) | ident '(' numberPlusMinus ')' -> ^( ASTVARIABLELAGLEAD ident numberPlusMinus FALSE ) | ident '[' numberPlusMinus ']' -> ^( ASTVARIABLELAGLEAD ident numberPlusMinus FALSE ) );
    public ModelParser.variableWithLagOrLead_return variableWithLagOrLead() // throws RecognitionException [1]
    {   
        ModelParser.variableWithLagOrLead_return retval = new ModelParser.variableWithLagOrLead_return();
        retval.Start = input.LT(1);
        int variableWithLagOrLead_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal77 = null;
        IToken char_literal79 = null;
        IToken char_literal81 = null;
        IToken char_literal83 = null;
        ModelParser.ident_return ident75 = default(ModelParser.ident_return);

        ModelParser.ident_return ident76 = default(ModelParser.ident_return);

        ModelParser.numberPlusMinus_return numberPlusMinus78 = default(ModelParser.numberPlusMinus_return);

        ModelParser.ident_return ident80 = default(ModelParser.ident_return);

        ModelParser.numberPlusMinus_return numberPlusMinus82 = default(ModelParser.numberPlusMinus_return);


        object char_literal77_tree=null;
        object char_literal79_tree=null;
        object char_literal81_tree=null;
        object char_literal83_tree=null;
        RewriteRuleTokenStream stream_RP = new RewriteRuleTokenStream(adaptor,"token RP");
        RewriteRuleTokenStream stream_86 = new RewriteRuleTokenStream(adaptor,"token 86");
        RewriteRuleTokenStream stream_88 = new RewriteRuleTokenStream(adaptor,"token 88");
        RewriteRuleTokenStream stream_89 = new RewriteRuleTokenStream(adaptor,"token 89");
        RewriteRuleSubtreeStream stream_ident = new RewriteRuleSubtreeStream(adaptor,"rule ident");
        RewriteRuleSubtreeStream stream_numberPlusMinus = new RewriteRuleSubtreeStream(adaptor,"rule numberPlusMinus");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 23) ) 
    	    {
    	    	return retval; 
    	    }
            // Model.g:212:4: ( ident -> ^( ASTVARIABLE ident FALSE ) | ident '(' numberPlusMinus ')' -> ^( ASTVARIABLELAGLEAD ident numberPlusMinus FALSE ) | ident '[' numberPlusMinus ']' -> ^( ASTVARIABLELAGLEAD ident numberPlusMinus FALSE ) )
            int alt15 = 3;
            alt15 = dfa15.Predict(input);
            switch (alt15) 
            {
                case 1 :
                    // Model.g:212:6: ident
                    {
                    	PushFollow(FOLLOW_ident_in_variableWithLagOrLead1115);
                    	ident75 = ident();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_ident.Add(ident75.Tree);


                    	// AST REWRITE
                    	// elements:          ident
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 212:13: -> ^( ASTVARIABLE ident FALSE )
                    	{
                    	    // Model.g:212:16: ^( ASTVARIABLE ident FALSE )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ASTVARIABLE, "ASTVARIABLE"), root_1);

                    	    adaptor.AddChild(root_1, stream_ident.NextTree());
                    	    adaptor.AddChild(root_1, (object)adaptor.Create(FALSE, "FALSE"));

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // Model.g:213:8: ident '(' numberPlusMinus ')'
                    {
                    	PushFollow(FOLLOW_ident_in_variableWithLagOrLead1135);
                    	ident76 = ident();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_ident.Add(ident76.Tree);
                    	char_literal77=(IToken)Match(input,86,FOLLOW_86_in_variableWithLagOrLead1137); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_86.Add(char_literal77);

                    	PushFollow(FOLLOW_numberPlusMinus_in_variableWithLagOrLead1139);
                    	numberPlusMinus78 = numberPlusMinus();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_numberPlusMinus.Add(numberPlusMinus78.Tree);
                    	char_literal79=(IToken)Match(input,RP,FOLLOW_RP_in_variableWithLagOrLead1141); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_RP.Add(char_literal79);



                    	// AST REWRITE
                    	// elements:          numberPlusMinus, ident
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 213:38: -> ^( ASTVARIABLELAGLEAD ident numberPlusMinus FALSE )
                    	{
                    	    // Model.g:213:41: ^( ASTVARIABLELAGLEAD ident numberPlusMinus FALSE )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ASTVARIABLELAGLEAD, "ASTVARIABLELAGLEAD"), root_1);

                    	    adaptor.AddChild(root_1, stream_ident.NextTree());
                    	    adaptor.AddChild(root_1, stream_numberPlusMinus.NextTree());
                    	    adaptor.AddChild(root_1, (object)adaptor.Create(FALSE, "FALSE"));

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 3 :
                    // Model.g:214:8: ident '[' numberPlusMinus ']'
                    {
                    	PushFollow(FOLLOW_ident_in_variableWithLagOrLead1163);
                    	ident80 = ident();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_ident.Add(ident80.Tree);
                    	char_literal81=(IToken)Match(input,88,FOLLOW_88_in_variableWithLagOrLead1165); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_88.Add(char_literal81);

                    	PushFollow(FOLLOW_numberPlusMinus_in_variableWithLagOrLead1167);
                    	numberPlusMinus82 = numberPlusMinus();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_numberPlusMinus.Add(numberPlusMinus82.Tree);
                    	char_literal83=(IToken)Match(input,89,FOLLOW_89_in_variableWithLagOrLead1169); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_89.Add(char_literal83);



                    	// AST REWRITE
                    	// elements:          numberPlusMinus, ident
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 214:38: -> ^( ASTVARIABLELAGLEAD ident numberPlusMinus FALSE )
                    	{
                    	    // Model.g:214:41: ^( ASTVARIABLELAGLEAD ident numberPlusMinus FALSE )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ASTVARIABLELAGLEAD, "ASTVARIABLELAGLEAD"), root_1);

                    	    adaptor.AddChild(root_1, stream_ident.NextTree());
                    	    adaptor.AddChild(root_1, stream_numberPlusMinus.NextTree());
                    	    adaptor.AddChild(root_1, (object)adaptor.Create(FALSE, "FALSE"));

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 23, variableWithLagOrLead_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "variableWithLagOrLead"

    public class numberPlusMinus_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "numberPlusMinus"
    // Model.g:217:1: numberPlusMinus : ( MINUS | PLUS ) ( Integer | Double ) ;
    public ModelParser.numberPlusMinus_return numberPlusMinus() // throws RecognitionException [1]
    {   
        ModelParser.numberPlusMinus_return retval = new ModelParser.numberPlusMinus_return();
        retval.Start = input.LT(1);
        int numberPlusMinus_StartIndex = input.Index();
        object root_0 = null;

        IToken set84 = null;
        IToken set85 = null;

        object set84_tree=null;
        object set85_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 24) ) 
    	    {
    	    	return retval; 
    	    }
            // Model.g:217:18: ( ( MINUS | PLUS ) ( Integer | Double ) )
            // Model.g:217:21: ( MINUS | PLUS ) ( Integer | Double )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set84 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= PLUS && input.LA(1) <= MINUS) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set84));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}

            	set85 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= Double && input.LA(1) <= Integer) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set85));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 24, numberPlusMinus_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "numberPlusMinus"

    public class logExp_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "logExp"
    // Model.g:219:1: logExp : ( LOG | EXP );
    public ModelParser.logExp_return logExp() // throws RecognitionException [1]
    {   
        ModelParser.logExp_return retval = new ModelParser.logExp_return();
        retval.Start = input.LT(1);
        int logExp_StartIndex = input.Index();
        object root_0 = null;

        IToken set86 = null;

        object set86_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 25) ) 
    	    {
    	    	return retval; 
    	    }
            // Model.g:219:7: ( LOG | EXP )
            // Model.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set86 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= LOG && input.LA(1) <= EXP) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set86));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 25, logExp_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "logExp"

    public class ident_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "ident"
    // Model.g:221:1: ident : ( Ident | extraTokens );
    public ModelParser.ident_return ident() // throws RecognitionException [1]
    {   
        ModelParser.ident_return retval = new ModelParser.ident_return();
        retval.Start = input.LT(1);
        int ident_StartIndex = input.Index();
        object root_0 = null;

        IToken Ident87 = null;
        ModelParser.extraTokens_return extraTokens88 = default(ModelParser.extraTokens_return);


        object Ident87_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 26) ) 
    	    {
    	    	return retval; 
    	    }
            // Model.g:221:9: ( Ident | extraTokens )
            int alt16 = 2;
            int LA16_0 = input.LA(1);

            if ( (LA16_0 == Ident) )
            {
                alt16 = 1;
            }
            else if ( ((LA16_0 >= LOG && LA16_0 <= VARLIST)) )
            {
                alt16 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d16s0 =
                    new NoViableAltException("", 16, 0, input);

                throw nvae_d16s0;
            }
            switch (alt16) 
            {
                case 1 :
                    // Model.g:221:12: Ident
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	Ident87=(IToken)Match(input,Ident,FOLLOW_Ident_in_ident1238); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{Ident87_tree = (object)adaptor.Create(Ident87);
                    		adaptor.AddChild(root_0, Ident87_tree);
                    	}

                    }
                    break;
                case 2 :
                    // Model.g:221:20: extraTokens
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_extraTokens_in_ident1242);
                    	extraTokens88 = extraTokens();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, extraTokens88.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 26, ident_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "ident"

    public class frmlEnding_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "frmlEnding"
    // Model.g:225:1: frmlEnding : ( '$' | ';' );
    public ModelParser.frmlEnding_return frmlEnding() // throws RecognitionException [1]
    {   
        ModelParser.frmlEnding_return retval = new ModelParser.frmlEnding_return();
        retval.Start = input.LT(1);
        int frmlEnding_StartIndex = input.Index();
        object root_0 = null;

        IToken set89 = null;

        object set89_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 27) ) 
    	    {
    	    	return retval; 
    	    }
            // Model.g:225:12: ( '$' | ';' )
            // Model.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set89 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 90 && input.LA(1) <= 91) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set89));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 27, frmlEnding_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "frmlEnding"

    public class pow_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "pow"
    // Model.g:233:1: pow : ( STARS -> ASTPOW | HAT -> ASTPOW );
    public ModelParser.pow_return pow() // throws RecognitionException [1]
    {   
        ModelParser.pow_return retval = new ModelParser.pow_return();
        retval.Start = input.LT(1);
        int pow_StartIndex = input.Index();
        object root_0 = null;

        IToken STARS90 = null;
        IToken HAT91 = null;

        object STARS90_tree=null;
        object HAT91_tree=null;
        RewriteRuleTokenStream stream_HAT = new RewriteRuleTokenStream(adaptor,"token HAT");
        RewriteRuleTokenStream stream_STARS = new RewriteRuleTokenStream(adaptor,"token STARS");

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 28) ) 
    	    {
    	    	return retval; 
    	    }
            // Model.g:233:9: ( STARS -> ASTPOW | HAT -> ASTPOW )
            int alt17 = 2;
            int LA17_0 = input.LA(1);

            if ( (LA17_0 == STARS) )
            {
                alt17 = 1;
            }
            else if ( (LA17_0 == HAT) )
            {
                alt17 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d17s0 =
                    new NoViableAltException("", 17, 0, input);

                throw nvae_d17s0;
            }
            switch (alt17) 
            {
                case 1 :
                    // Model.g:233:17: STARS
                    {
                    	STARS90=(IToken)Match(input,STARS,FOLLOW_STARS_in_pow1338); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_STARS.Add(STARS90);



                    	// AST REWRITE
                    	// elements:          
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 233:24: -> ASTPOW
                    	{
                    	    adaptor.AddChild(root_0, (object)adaptor.Create(ASTPOW, "ASTPOW"));

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // Model.g:234:17: HAT
                    {
                    	HAT91=(IToken)Match(input,HAT,FOLLOW_HAT_in_pow1361); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_HAT.Add(HAT91);



                    	// AST REWRITE
                    	// elements:          
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 234:24: -> ASTPOW
                    	{
                    	    adaptor.AddChild(root_0, (object)adaptor.Create(ASTPOW, "ASTPOW"));

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 28, pow_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "pow"

    // $ANTLR start "synpred30_Model"
    public void synpred30_Model_fragment() {
        // Model.g:203:4: ( functionLogExp )
        // Model.g:203:4: functionLogExp
        {
        	PushFollow(FOLLOW_functionLogExp_in_synpred30_Model1039);
        	functionLogExp();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred30_Model"

    // $ANTLR start "synpred31_Model"
    public void synpred31_Model_fragment() {
        // Model.g:204:4: ( variableWithLagOrLead )
        // Model.g:204:4: variableWithLagOrLead
        {
        	PushFollow(FOLLOW_variableWithLagOrLead_in_synpred31_Model1063);
        	variableWithLagOrLead();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred31_Model"

    // $ANTLR start "synpred32_Model"
    public void synpred32_Model_fragment() {
        // Model.g:205:4: ( function )
        // Model.g:205:4: function
        {
        	PushFollow(FOLLOW_function_in_synpred32_Model1075);
        	function();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred32_Model"

    // Delegated rules

   	public bool synpred32_Model() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred32_Model_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred30_Model() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred30_Model_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred31_Model() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred31_Model_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}


   	protected DFA6 dfa6;
   	protected DFA8 dfa8;
   	protected DFA14 dfa14;
   	protected DFA15 dfa15;
	private void InitializeCyclicDFAs()
	{
    	this.dfa6 = new DFA6(this);
    	this.dfa8 = new DFA8(this);
    	this.dfa14 = new DFA14(this);
    	this.dfa15 = new DFA15(this);


	    this.dfa14.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA14_SpecialStateTransition);

	}

    const string DFA6_eotS =
        "\x0a\uffff";
    const string DFA6_eofS =
        "\x0a\uffff";
    const string DFA6_minS =
        "\x01\x04\x09\uffff";
    const string DFA6_maxS =
        "\x01\x56\x09\uffff";
    const string DFA6_acceptS =
        "\x01\uffff\x01\x01\x07\uffff\x01\x02";
    const string DFA6_specialS =
        "\x0a\uffff}>";
    static readonly string[] DFA6_transitionS = {
            "\x07\x01\x01\uffff\x01\x01\x05\uffff\x01\x09\x17\uffff\x03"+
            "\x01\x01\uffff\x01\x01\x27\uffff\x01\x01",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA6_eot = DFA.UnpackEncodedString(DFA6_eotS);
    static readonly short[] DFA6_eof = DFA.UnpackEncodedString(DFA6_eofS);
    static readonly char[] DFA6_min = DFA.UnpackEncodedStringToUnsignedChars(DFA6_minS);
    static readonly char[] DFA6_max = DFA.UnpackEncodedStringToUnsignedChars(DFA6_maxS);
    static readonly short[] DFA6_accept = DFA.UnpackEncodedString(DFA6_acceptS);
    static readonly short[] DFA6_special = DFA.UnpackEncodedString(DFA6_specialS);
    static readonly short[][] DFA6_transition = DFA.UnpackEncodedStringArray(DFA6_transitionS);

    protected class DFA6 : DFA
    {
        public DFA6(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 6;
            this.eot = DFA6_eot;
            this.eof = DFA6_eof;
            this.min = DFA6_min;
            this.max = DFA6_max;
            this.accept = DFA6_accept;
            this.special = DFA6_special;
            this.transition = DFA6_transition;

        }

        override public string Description
        {
            get { return "177:22: ( expression ( ',' expression )* )?"; }
        }

    }

    const string DFA8_eotS =
        "\x0a\uffff";
    const string DFA8_eofS =
        "\x0a\uffff";
    const string DFA8_minS =
        "\x01\x04\x09\uffff";
    const string DFA8_maxS =
        "\x01\x56\x09\uffff";
    const string DFA8_acceptS =
        "\x01\uffff\x01\x01\x07\uffff\x01\x02";
    const string DFA8_specialS =
        "\x0a\uffff}>";
    static readonly string[] DFA8_transitionS = {
            "\x07\x01\x01\uffff\x01\x01\x05\uffff\x01\x09\x17\uffff\x03"+
            "\x01\x01\uffff\x01\x01\x27\uffff\x01\x01",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA8_eot = DFA.UnpackEncodedString(DFA8_eotS);
    static readonly short[] DFA8_eof = DFA.UnpackEncodedString(DFA8_eofS);
    static readonly char[] DFA8_min = DFA.UnpackEncodedStringToUnsignedChars(DFA8_minS);
    static readonly char[] DFA8_max = DFA.UnpackEncodedStringToUnsignedChars(DFA8_maxS);
    static readonly short[] DFA8_accept = DFA.UnpackEncodedString(DFA8_acceptS);
    static readonly short[] DFA8_special = DFA.UnpackEncodedString(DFA8_specialS);
    static readonly short[][] DFA8_transition = DFA.UnpackEncodedStringArray(DFA8_transitionS);

    protected class DFA8 : DFA
    {
        public DFA8(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 8;
            this.eot = DFA8_eot;
            this.eof = DFA8_eof;
            this.min = DFA8_min;
            this.max = DFA8_max;
            this.accept = DFA8_accept;
            this.special = DFA8_special;
            this.transition = DFA8_transition;

        }

        override public string Description
        {
            get { return "178:28: ( expression ( ',' expression )* )?"; }
        }

    }

    const string DFA14_eotS =
        "\x27\uffff";
    const string DFA14_eofS =
        "\x03\uffff\x03\x07\x21\uffff";
    const string DFA14_minS =
        "\x01\x04\x02\uffff\x03\x0b\x09\uffff\x01\x00\x0a\uffff\x01\x00"+
        "\x09\uffff\x01\x00\x02\uffff";
    const string DFA14_maxS =
        "\x01\x2e\x02\uffff\x03\x5b\x09\uffff\x01\x00\x0a\uffff\x01\x00"+
        "\x09\uffff\x01\x00\x02\uffff";
    const string DFA14_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x03\uffff\x01\x06\x01\x04\x1d\uffff"+
        "\x01\x03\x01\x05";
    const string DFA14_specialS =
        "\x0f\uffff\x01\x00\x0a\uffff\x01\x01\x09\uffff\x01\x02\x02\uffff}>";
    static readonly string[] DFA14_transitionS = {
            "\x02\x03\x05\x05\x1f\uffff\x01\x02\x01\x01\x01\x04\x01\uffff"+
            "\x01\x06",
            "",
            "",
            "\x02\x07\x01\uffff\x02\x07\x02\uffff\x01\x07\x1a\uffff\x01"+
            "\x07\x01\uffff\x02\x07\x25\uffff\x01\x0f\x02\x07\x01\uffff\x02"+
            "\x07",
            "\x02\x07\x01\uffff\x02\x07\x02\uffff\x01\x07\x1a\uffff\x01"+
            "\x07\x01\uffff\x02\x07\x25\uffff\x01\x1a\x02\x07\x01\uffff\x02"+
            "\x07",
            "\x02\x07\x01\uffff\x02\x07\x02\uffff\x01\x07\x1a\uffff\x01"+
            "\x07\x01\uffff\x02\x07\x25\uffff\x01\x24\x02\x07\x01\uffff\x02"+
            "\x07",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\uffff",
            "",
            ""
    };

    static readonly short[] DFA14_eot = DFA.UnpackEncodedString(DFA14_eotS);
    static readonly short[] DFA14_eof = DFA.UnpackEncodedString(DFA14_eofS);
    static readonly char[] DFA14_min = DFA.UnpackEncodedStringToUnsignedChars(DFA14_minS);
    static readonly char[] DFA14_max = DFA.UnpackEncodedStringToUnsignedChars(DFA14_maxS);
    static readonly short[] DFA14_accept = DFA.UnpackEncodedString(DFA14_acceptS);
    static readonly short[] DFA14_special = DFA.UnpackEncodedString(DFA14_specialS);
    static readonly short[][] DFA14_transition = DFA.UnpackEncodedStringArray(DFA14_transitionS);

    protected class DFA14 : DFA
    {
        public DFA14(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 14;
            this.eot = DFA14_eot;
            this.eof = DFA14_eof;
            this.min = DFA14_min;
            this.max = DFA14_max;
            this.accept = DFA14_accept;
            this.special = DFA14_special;
            this.transition = DFA14_transition;

        }

        override public string Description
        {
            get { return "200:1: value : ( Integer -> ^( ASTINTEGER Integer ) | Double -> ^( ASTDOUBLE Double ) | functionLogExp | variableWithLagOrLead | function | assignVar );"; }
        }

    }


    protected internal int DFA14_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA14_15 = input.LA(1);

                   	 
                   	int index14_15 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred30_Model()) ) { s = 37; }

                   	else if ( (synpred31_Model()) ) { s = 7; }

                   	else if ( (synpred32_Model()) ) { s = 38; }

                   	 
                   	input.Seek(index14_15);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA14_26 = input.LA(1);

                   	 
                   	int index14_26 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred31_Model()) ) { s = 7; }

                   	else if ( (synpred32_Model()) ) { s = 38; }

                   	 
                   	input.Seek(index14_26);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA14_36 = input.LA(1);

                   	 
                   	int index14_36 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred31_Model()) ) { s = 7; }

                   	else if ( (synpred32_Model()) ) { s = 38; }

                   	 
                   	input.Seek(index14_36);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae14 =
            new NoViableAltException(dfa.Description, 14, _s, input);
        dfa.Error(nvae14);
        throw nvae14;
    }
    const string DFA15_eotS =
        "\x17\uffff";
    const string DFA15_eofS =
        "\x01\uffff\x02\x03\x14\uffff";
    const string DFA15_minS =
        "\x01\x04\x02\x0b\x14\uffff";
    const string DFA15_maxS =
        "\x01\x2c\x02\x5b\x14\uffff";
    const string DFA15_acceptS =
        "\x03\uffff\x01\x01\x07\uffff\x01\x03\x01\x02\x0a\uffff";
    const string DFA15_specialS =
        "\x17\uffff}>";
    static readonly string[] DFA15_transitionS = {
            "\x07\x02\x21\uffff\x01\x01",
            "\x02\x03\x01\uffff\x02\x03\x02\uffff\x01\x03\x1a\uffff\x01"+
            "\x03\x01\uffff\x02\x03\x25\uffff\x01\x0c\x01\x03\x01\x0b\x01"+
            "\uffff\x02\x03",
            "\x02\x03\x01\uffff\x02\x03\x02\uffff\x01\x03\x1a\uffff\x01"+
            "\x03\x01\uffff\x02\x03\x25\uffff\x01\x0c\x01\x03\x01\x0b\x01"+
            "\uffff\x02\x03",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA15_eot = DFA.UnpackEncodedString(DFA15_eotS);
    static readonly short[] DFA15_eof = DFA.UnpackEncodedString(DFA15_eofS);
    static readonly char[] DFA15_min = DFA.UnpackEncodedStringToUnsignedChars(DFA15_minS);
    static readonly char[] DFA15_max = DFA.UnpackEncodedStringToUnsignedChars(DFA15_maxS);
    static readonly short[] DFA15_accept = DFA.UnpackEncodedString(DFA15_acceptS);
    static readonly short[] DFA15_special = DFA.UnpackEncodedString(DFA15_specialS);
    static readonly short[][] DFA15_transition = DFA.UnpackEncodedStringArray(DFA15_transitionS);

    protected class DFA15 : DFA
    {
        public DFA15(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 15;
            this.eot = DFA15_eot;
            this.eof = DFA15_eof;
            this.min = DFA15_min;
            this.max = DFA15_max;
            this.accept = DFA15_accept;
            this.special = DFA15_special;
            this.transition = DFA15_transition;

        }

        override public string Description
        {
            get { return "211:1: variableWithLagOrLead : ( ident -> ^( ASTVARIABLE ident FALSE ) | ident '(' numberPlusMinus ')' -> ^( ASTVARIABLELAGLEAD ident numberPlusMinus FALSE ) | ident '[' numberPlusMinus ']' -> ^( ASTVARIABLELAGLEAD ident numberPlusMinus FALSE ) );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_set_in_extraTokens0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr2_in_expr450 = new BitSet(new ulong[]{0x00000200000003C0UL,0x000000000C000000UL});
    public static readonly BitSet FOLLOW_EOF_in_expr454 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_frml_in_expr2474 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_val_in_expr2480 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Modelblock_in_expr2486 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_AFTER_in_expr2500 = new BitSet(new ulong[]{0x00000200000003C0UL,0x000000000C000000UL});
    public static readonly BitSet FOLLOW_frmlEnding_in_expr2502 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_AFTER2_in_expr2515 = new BitSet(new ulong[]{0x00000200000003C0UL,0x000000000C000000UL});
    public static readonly BitSet FOLLOW_frmlEnding_in_expr2517 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_frmlEnding_in_expr2532 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FRML_in_frml565 = new BitSet(new ulong[]{0x00001000000007F0UL});
    public static readonly BitSet FOLLOW_code_in_frml567 = new BitSet(new ulong[]{0x00001000000007F0UL});
    public static readonly BitSet FOLLOW_genrLeftSide_in_frml569 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_85_in_frml571 = new BitSet(new ulong[]{0x00005C00000017F0UL,0x0000000000400000UL});
    public static readonly BitSet FOLLOW_expression2_in_frml573 = new BitSet(new ulong[]{0x00000200000003C0UL,0x000000000C000000UL});
    public static readonly BitSet FOLLOW_frmlEnding_in_frml575 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_genrLeftSide2_in_genrLeftSide611 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_genrLeftSide2627 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_simpleFunction_in_genrLeftSide2629 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_code637 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_expression2652 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_number667 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VAL_in_val679 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_Ident_in_val681 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_85_in_val683 = new BitSet(new ulong[]{0x00000C0000001000UL});
    public static readonly BitSet FOLLOW_MINUS_in_val685 = new BitSet(new ulong[]{0x00000C0000001000UL});
    public static readonly BitSet FOLLOW_number_in_val688 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_simpleFunction715 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000400000UL});
    public static readonly BitSet FOLLOW_86_in_simpleFunction717 = new BitSet(new ulong[]{0x00001000000007F0UL});
    public static readonly BitSet FOLLOW_ident_in_simpleFunction719 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_RP_in_simpleFunction721 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_function742 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000400000UL});
    public static readonly BitSet FOLLOW_86_in_function744 = new BitSet(new ulong[]{0x00005C00000417F0UL,0x0000000000400000UL});
    public static readonly BitSet FOLLOW_expression_in_function748 = new BitSet(new ulong[]{0x0000000000040000UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_87_in_function751 = new BitSet(new ulong[]{0x00005C00000017F0UL,0x0000000000400000UL});
    public static readonly BitSet FOLLOW_expression_in_function753 = new BitSet(new ulong[]{0x0000000000040000UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_RP_in_function760 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_logExp_in_functionLogExp780 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000400000UL});
    public static readonly BitSet FOLLOW_86_in_functionLogExp782 = new BitSet(new ulong[]{0x00005C00000417F0UL,0x0000000000400000UL});
    public static readonly BitSet FOLLOW_expression_in_functionLogExp786 = new BitSet(new ulong[]{0x0000000000040000UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_87_in_functionLogExp789 = new BitSet(new ulong[]{0x00005C00000017F0UL,0x0000000000400000UL});
    public static readonly BitSet FOLLOW_expression_in_functionLogExp791 = new BitSet(new ulong[]{0x0000000000040000UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_RP_in_functionLogExp798 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_86_in_lagFunction823 = new BitSet(new ulong[]{0x00005C00000017F0UL,0x0000000000400000UL});
    public static readonly BitSet FOLLOW_expression_in_lagFunction825 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_RP_in_lagFunction827 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000400000UL});
    public static readonly BitSet FOLLOW_86_in_lagFunction829 = new BitSet(new ulong[]{0x0000000000001800UL});
    public static readonly BitSet FOLLOW_numberPlusMinus_in_lagFunction831 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_RP_in_lagFunction833 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_expression859 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression868 = new BitSet(new ulong[]{0x0000000000001802UL});
    public static readonly BitSet FOLLOW_set_in_additiveExpression872 = new BitSet(new ulong[]{0x00005C00000017F0UL,0x0000000000400000UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression879 = new BitSet(new ulong[]{0x0000000000001802UL});
    public static readonly BitSet FOLLOW_powerExpression_in_multiplicativeExpression892 = new BitSet(new ulong[]{0x000020000000C002UL});
    public static readonly BitSet FOLLOW_set_in_multiplicativeExpression896 = new BitSet(new ulong[]{0x00005C00000017F0UL,0x0000000000400000UL});
    public static readonly BitSet FOLLOW_powerExpression_in_multiplicativeExpression905 = new BitSet(new ulong[]{0x000020000000C002UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_powerExpression918 = new BitSet(new ulong[]{0x0001800000000002UL});
    public static readonly BitSet FOLLOW_pow_in_powerExpression922 = new BitSet(new ulong[]{0x00005C00000017F0UL,0x0000000000400000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_powerExpression925 = new BitSet(new ulong[]{0x0001800000000002UL});
    public static readonly BitSet FOLLOW_primaryExpression_in_unaryExpression940 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MINUS_in_unaryExpression951 = new BitSet(new ulong[]{0x00005C00000007F0UL,0x0000000000400000UL});
    public static readonly BitSet FOLLOW_primaryExpression_in_unaryExpression953 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_86_in_primaryExpression980 = new BitSet(new ulong[]{0x00005C00000017F0UL,0x0000000000400000UL});
    public static readonly BitSet FOLLOW_expression_in_primaryExpression983 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_RP_in_primaryExpression985 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_value_in_primaryExpression993 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Integer_in_value1007 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Double_in_value1022 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functionLogExp_in_value1039 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableWithLagOrLead_in_value1063 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_function_in_value1075 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_assignVar_in_value1083 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_AssignVar_in_assignVar1094 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_variableWithLagOrLead1115 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_variableWithLagOrLead1135 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000400000UL});
    public static readonly BitSet FOLLOW_86_in_variableWithLagOrLead1137 = new BitSet(new ulong[]{0x0000000000001800UL});
    public static readonly BitSet FOLLOW_numberPlusMinus_in_variableWithLagOrLead1139 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_RP_in_variableWithLagOrLead1141 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_variableWithLagOrLead1163 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000001000000UL});
    public static readonly BitSet FOLLOW_88_in_variableWithLagOrLead1165 = new BitSet(new ulong[]{0x0000000000001800UL});
    public static readonly BitSet FOLLOW_numberPlusMinus_in_variableWithLagOrLead1167 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000002000000UL});
    public static readonly BitSet FOLLOW_89_in_variableWithLagOrLead1169 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_numberPlusMinus1203 = new BitSet(new ulong[]{0x00000C0000000000UL});
    public static readonly BitSet FOLLOW_set_in_numberPlusMinus1209 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_logExp0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Ident_in_ident1238 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_extraTokens_in_ident1242 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_frmlEnding0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STARS_in_pow1338 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_HAT_in_pow1361 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functionLogExp_in_synpred30_Model1039 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableWithLagOrLead_in_synpred31_Model1063 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_function_in_synpred32_Model1075 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}