//
//  ContentView.swift
//  BagelGram
//
//  Created by Aaron Osteraas on 19/11/19.
//  Copyright © 2019 Aaron Osteraas. All rights reserved.
//

import SwiftUI
import Apollo
import Network


struct ContentView: View {
    
    init() {
        let navAppearance = UINavigationBar.appearance()
        navAppearance.barTintColor = UISettings.bagelPink
        navAppearance.titleTextAttributes = [
            .font: UISettings.bagelFont!,
            .foregroundColor: UIColor.white
        ]
    }
    
    var body: some View {
        NavigationView {

            AppView()
            .navigationBarTitle("BagelGram", displayMode: .inline)
        }
    }
}

struct ContentView_Previews: PreviewProvider {
    static var previews: some View {
        ContentView()
    }
}
