﻿using System.Collections.Generic;

namespace M11J1.AST
{
    public interface IDeclaration
    {
        Type GetVariableType();
        int GetNumber(string variableId);
        int GetNumber();
        //string GetName();
        Dictionary<string, string> DeclarationIds { get; set; }
        List<VariableDeclaration> GetList();
    }
}
